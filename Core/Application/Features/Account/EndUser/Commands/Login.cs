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
using ThirdPartyServices.Storage;

namespace Application.Features.Account.EndUser.Commands
{
    public class LoginCommand : UserLoginRequest, IRequest<CommandResponse<TokenResponse>>
    {
    }
    public class LoginCommandHandler : IRequestHandler<LoginCommand, CommandResponse<TokenResponse>>
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IAccountRepository<User> _accountRepository;
        public LoginCommandHandler(UserManager<User> userManager, SignInManager<User> signInManager, IAccountRepository<User> accountRepository)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _accountRepository = accountRepository;
        }
        public async Task<CommandResponse<TokenResponse>> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByNameAsync(request.Username);
            if (user == null)
                throw new AuthFailedException("Username is not exist");
            var result = await _signInManager.PasswordSignInAsync(user, request.Password, request.RememberMe, true);
            if (!result.Succeeded)
                throw new AuthFailedException("Username or password is invalid");
            var checkEndUser = await _userManager.IsInRoleAsync(user,"ADMIN")|| await _userManager.IsInRoleAsync(user, "SUPPERADMIN");
            if (checkEndUser == true)
                throw new UnauthorizeException("Login with account enduser");
            var token = new TokenResponse()
            {
                UserId = user.Id,
                Username = user.UserName,
                Token = await _accountRepository.GenerateToken(user)
            };
            return new CommandOK<TokenResponse>()
            {
                Msg = "Login OK",
                Data = token
            };
        }
    }
}
