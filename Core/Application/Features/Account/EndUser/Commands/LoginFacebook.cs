using Application.DTOs.User;
using Application.DTOs.User.UserRequest;
using Application.Enum;
using Application.Exceptions;
using Application.Features.Account.Base.Queries;
using Application.Interfaces.Repo;
using Application.Wrappers;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Transactions;
using ThirdPartyServices.FacebookAuth;
using ThirdPartyServices.Storage;

namespace Application.Features.Account.EndUser.Commands
{
    public class LoginFBCommand : IRequest<CommandResponse<TokenResponse>>
    {
        public string Token { get; set; }
    }
    public class LoginFBCommandHandler : IRequestHandler<LoginFBCommand, CommandResponse<TokenResponse>>
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IAccountRepository<User> _accountRepository;
        private readonly IFacebookAuthService _facebookAuthService;
        public LoginFBCommandHandler(UserManager<User> userManager, SignInManager<User> signInManager, IAccountRepository<User> accountRepository, IFacebookAuthService facebookAuthService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _accountRepository = accountRepository;
            _facebookAuthService = facebookAuthService;
        }
        public async Task<CommandResponse<TokenResponse>> Handle(LoginFBCommand request, CancellationToken cancellationToken)
        {
            var validateRS = await _facebookAuthService.ValidateAccessToken(request.Token);
            if (!validateRS.Data.IsValid)
            {
                throw new UnauthorizeException("Token is invalid");
            }
            var userFbInfor = await _facebookAuthService.GetUserInfor(request.Token);
            var user = await _userManager.FindByEmailAsync(userFbInfor.Email);
            if (user != null)
            {

                return new CommandOK<TokenResponse>()
                {
                    Msg = "Login Facebook OK",
                    Data = new TokenResponse()
                    {
                        UserId = user.Id,
                        Username = user.UserName,
                        Token = await _accountRepository.GenerateToken(user)
                    }
                };
            }
            if (user == null)
            {
                user = new Domain.Entities.User()
                {
                    Email = userFbInfor.Email,
                    FirstName = userFbInfor.FirstName,
                    LastName = userFbInfor.LastName,
                    UserName = userFbInfor.Email,
                    AccountType = AccountType.FACEBOOK.ToString(),
                    Thumbnail = userFbInfor.Picture.Data.Url.ToString()
                };
                var rs = await _userManager.CreateAsync(user);
                if (!rs.Succeeded)
                    throw new BadRequestException("Create user from Facebook fail");
                var rsRole = await _userManager.AddToRoleAsync(user, "USER");
                var token = new TokenResponse()
                {
                    Token = await _accountRepository.GenerateToken(user),
                    UserId = user.Id,
                    Username = user.Email

                };
                //await _sendMailService.SendMailNotify("Vip pro", "<h1>BBB aaaaaaaaaaaaaaaaa</h1>", user.Email);
                return new CommandOK<TokenResponse>()
                {
                    Msg = "Login Facebook OK",
                    Data = token,
                };

            }
            throw new BadRequestException("Create user from Facebook fail");
        }
    }
}
