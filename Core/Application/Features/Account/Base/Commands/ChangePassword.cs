using Application.DTOs.User;
using Application.DTOs.User.UserRequest;
using Application.Enum;
using Application.Exceptions;
using Application.Features.Account.Base.Queries;
using Application.Interfaces.Service;
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

namespace Application.Features.Account.Base.Commands
{
    public class ChangePasswordCommand : ChangePasswordRequest, IRequest<CommandResponse<TokenResponse>>
    {
    }
    public class ChangePasswordCommandHandler : IRequestHandler<ChangePasswordCommand, CommandResponse<TokenResponse>>
    {
        private readonly UserManager<Domain.Entities.User> _userManager;
        private readonly IToken _token;
        private readonly ISendMailService _sendMailService;
        private readonly IAuthenticatedUserService _authenticatedUserService;
        public ChangePasswordCommandHandler(UserManager<Domain.Entities.User> userManager,
            IToken token,ISendMailService sendMailService, IAuthenticatedUserService authenticatedUserService)
        {
            _userManager = userManager;
            _token = token;
            _sendMailService = sendMailService;
            _authenticatedUserService = authenticatedUserService;

        }
        public async Task<CommandResponse<TokenResponse>> Handle(ChangePasswordCommand request, CancellationToken cancellationToken)
        {
            var userId = _authenticatedUserService.GetCurrentUserId();
            var user = await _userManager.FindByIdAsync(userId.ToString());
            var checkPwd = await _userManager.CheckPasswordAsync(user, request.OldPassword);
            if (!checkPwd)
                throw new AuthFailedException("Old password is invalid!");
            var res = await _userManager.ChangePasswordAsync(user, request.OldPassword, request.NewPassword);
            if (res.Succeeded)
            {
                await _userManager.UpdateSecurityStampAsync(user);
                var token = new TokenResponse()
                {
                    Token = await _token.GenerateToken(user),
                    UserId = user.Id,
                    Username = user.Email

                };
                return new CommandOK<TokenResponse>()
                {
                    Msg = "ChangePassword OK",
                    Data = token,
                };
            }
 
            throw new CreateRequestException("ChangePassword Failed");

        }
    }
}
