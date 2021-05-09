using Application.DTOs.User;
using Application.DTOs.User.UserRequest;
using Application.Enum;
using Application.Exceptions;
using Application.Features.Account.Base.Queries;
using Application.Interfaces.Service;
using Application.Wrappers;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ThirdPartyServices.Hash;
using ThirdPartyServices.SendMail;
using ThirdPartyServices.Storage;

namespace Application.Features.Account.Base.Commands
{
    public class SendVerifyEmailCommand : IRequest<CommandResponse<string>>
    {
        public string Email { get; set; }
    }
    public class SendVerifyEmailCommandHandler : IRequestHandler<SendVerifyEmailCommand, CommandResponse<string>>
    {
        private readonly UserManager<Domain.Entities.User> _userManager;
        private readonly ISendMailService _sendMailService;
        private readonly IConfiguration _config;
        private readonly IHashService _hash;
        public SendVerifyEmailCommandHandler(UserManager<Domain.Entities.User> userManager, ISendMailService sendMailService, IConfiguration config,IHashService hash)
        {
            _userManager = userManager;
            _sendMailService = sendMailService;
            _config = config;
            _hash = hash;
        }
        public async Task<CommandResponse<string>> Handle(SendVerifyEmailCommand request, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByEmailAsync(request.Email);
            if (user == null)
                throw new NotFoundException("Not found user with email " + request.Email);

            var BaseLinkVerify = _config["Hostbase"] + "api/v1/EndUser/VerifyEmail?e={0}&c={1}";
            var e = _hash.Base64Encode(request.Email);
            var c = _hash.Sha256Hash(request.Email);
            var linkVerify = string.Format(BaseLinkVerify, e, c);
            try
            {
                await _sendMailService.SendMailNotify("Verify email", "Click to verify email : " + linkVerify, user.Email);
            }
            catch
            {
                throw new BadRequestException("Send mail fail");
            }


            return new CommandOK<string>()
            {
                Msg = "Send link verify email to " + request.Email + " OK. Check email and verify",
                Data = null,
            };

            throw new CreateRequestException("Send Verify Email Failed");

        }
    }
}
