using Application.DTOs.User;
using Application.DTOs.User.UserRequest;
using Application.Enum;
using Application.Exceptions;
using Application.Features.Account.Base.Queries;
using Application.Wrappers;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ThirdPartyServices.SendMail;
using ThirdPartyServices.Storage;

namespace Application.Features.Account.EndUser.Commands
{
    public class RegisterCommand : UserRegisterRequest, IRequest<CommandResponse<TokenResponse>>
    {
    }
    public class RegisterCommandHandler : IRequestHandler<RegisterCommand, CommandResponse<TokenResponse>>
    {
        private readonly UserManager<Domain.Entities.User> _userManager;
        private readonly IToken _token;
        private readonly IStorageService _storageService;
        private readonly ISendMailService _sendMailService; 
        public RegisterCommandHandler(UserManager<Domain.Entities.User> userManager,
            IToken token, IStorageService storageService, ISendMailService sendMailService)
        {
            _userManager = userManager;
            _token = token;
            _storageService = storageService;
            _sendMailService = sendMailService;
        }
        public async Task<CommandResponse<TokenResponse>> Handle(RegisterCommand request, CancellationToken cancellationToken)
        {
            if(await _userManager.FindByEmailAsync(request.Email)!= null)
            {
                throw new BadRequestException("Email has been registered");
            }
            var user = new Domain.Entities.User()
            {
                Dob = request.Dob ?? DateTime.Now,
                Email = request.Email,
                FirstName = request.FirstName,
                LastName = request.LastName,
                UserName = request.Email,
                EmailConfirmed = false,
                PhoneNumber = request.PhoneNumber ?? "0",
                AccountType = AccountType.SYSTEM.ToString(),

            };
            if (request.Thumbnail != null)
            {
                user.Thumbnail = await _storageService.SaveFile(request.Thumbnail, 0);
            }
            
            var result = await _userManager.CreateAsync(user, request.Password);

            try
            {
                if (result.Succeeded)
                {
                    var rsRole = await _userManager.AddToRoleAsync(user, "USER");
                    var token = new TokenResponse()
                    {
                        Token = await _token.GenerateToken(user),
                        UserId = user.Id,
                        Username = user.Email

                    };
                    await _sendMailService.SendMailNotify("Welcome to BigBlueBirds", "Welcome to BigBlueBirds", user.Email);
                    return new CommandOK<TokenResponse>()
                    {
                        Msg = "Register OK",
                        Data = token,
                    };

                }
            }
            catch(Exception e)
            {
                throw new CreateRequestException(e.Message);
            }
            throw new CreateRequestException("Register Failed");

        }
    }
}
