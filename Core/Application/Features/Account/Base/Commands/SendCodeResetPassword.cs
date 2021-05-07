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
    public class SendCodeResetPasswordCommand : IRequest<CommandResponse<string>>
    {
        public string Email { get; set; }
    }
    public class SendCodeResetPasswordCommandHandler : IRequestHandler<SendCodeResetPasswordCommand, CommandResponse<string>>
    {
        private readonly UserManager<Domain.Entities.User> _userManager;
        private readonly ISendMailService _sendMailService;
        public SendCodeResetPasswordCommandHandler(UserManager<Domain.Entities.User> userManager, ISendMailService sendMailService)
        {
            _userManager = userManager;
            _sendMailService = sendMailService;

        }
        public async Task<CommandResponse<string>> Handle(SendCodeResetPasswordCommand request, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByEmailAsync(request.Email);
            if (user == null)
                throw new NotFoundException("Not found user with email " + request.Email);
            var code = new Random().Next(100000, 1000000).ToString();
            user.ResetCode = code;
            try
            {
                await _sendMailService.SendMailNotify("Code confirm reset password", "Code is: " + code, user.Email);
                await _userManager.UpdateAsync(user);
            }
            catch
            {
                throw new BadRequestException("Send mail fail");
            }


            return new CommandOK<string>()
            {
                Msg = "Send Code Reset Password to "+request.Email +" OK",
                Data = null,
            };

            throw new CreateRequestException("SendCodeResetPassword Failed");

        }
    }
}
