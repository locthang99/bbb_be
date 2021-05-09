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
    public class VerifyEmailCommand : IRequest<string>
    {
        public string e { get; set; }
        public string c { get; set; }
    }
    public class VerifyEmailCommandHandler : IRequestHandler<VerifyEmailCommand, string>
    {
        private readonly UserManager<Domain.Entities.User> _userManager;
        private readonly ISendMailService _sendMailService;
        private readonly IConfiguration _config;
        private readonly IHashService _hash;
        public VerifyEmailCommandHandler(UserManager<Domain.Entities.User> userManager, ISendMailService sendMailService, IConfiguration config, IHashService hash)
        {
            _userManager = userManager;
            _sendMailService = sendMailService;
            _config = config;
            _hash = hash;
        }
        public async Task<string> Handle(VerifyEmailCommand request, CancellationToken cancellationToken)
        {
            var email = _hash.Base64Decode(request.e);
            var checkHash = _hash.Sha256Hash(email);
            var user = await _userManager.FindByEmailAsync(email);
            if (user == null||request.c!=checkHash)
                return "Link verify email not valid";
            if (user.EmailConfirmed)
                return "This user confirmed from before";
            user.EmailConfirmed = true;
            var rs = await _userManager.UpdateAsync(user);
            if (rs.Succeeded)
                return "Verify with email: " + email + " OK ";
            else
                return "Verify with email: " + email + " FAILED ";
        }
    }
}
