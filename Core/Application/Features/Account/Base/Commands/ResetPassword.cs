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
    public class ResetPasswordCommand : ResetPasswordRequest, IRequest<CommandResponse<TokenResponse>>
    {
    }
    public class ResetPasswordCommandHandler : IRequestHandler<ResetPasswordCommand, CommandResponse<TokenResponse>>
    {
        private readonly UserManager<Domain.Entities.User> _userManager;
        private readonly IToken _token;
        public ResetPasswordCommandHandler(UserManager<Domain.Entities.User> userManager,
            IToken token)
        {
            _userManager = userManager;
            _token = token;

        }
        public async Task<CommandResponse<TokenResponse>> Handle(ResetPasswordCommand request, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByEmailAsync(request.Email);
            if (user == null)
                throw new NotFoundException("Not found user with email " + request.Email);
            if (user.ResetCode != request.ResetCode || string.IsNullOrEmpty(user.ResetCode))
                throw new AuthFailedException("Reset code is invalid");
            var tokenReset = await  _userManager.GeneratePasswordResetTokenAsync(user);
            var res = await _userManager.ResetPasswordAsync(user, tokenReset, request.NewPassword);
            if (res.Succeeded)
            {
                user.ResetCode = "";
                await _userManager.UpdateAsync(user);
                await _userManager.UpdateSecurityStampAsync(user);
                var token = new TokenResponse()
                {
                    Token = await _token.GenerateToken(user),
                    UserId = user.Id,
                    Username = user.Email

                };
                return new CommandOK<TokenResponse>()
                {
                    Msg = "Reset Password OK",
                    Data = token,
                };
            }

            throw new CreateRequestException("ResetPassword Failed");

        }
    }
}
