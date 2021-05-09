using Application.DTOs.User;
using Application.DTOs.User.UserRequest;
using Application.Enum;
using Application.Exceptions;
using Application.Features.Account.Base.Queries;
using Application.Interfaces.Service;
using Application.Wrappers;
using Domain.Entities;
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
    public class UpdateProfileCommand : UserUpdateRequest, IRequest<CommandResponse<TokenResponse>>
    {
    }
    public class UpdateProfileCommandHandler : IRequestHandler<UpdateProfileCommand, CommandResponse<TokenResponse>>
    {
        private readonly UserManager<Domain.Entities.User> _userManager;
        private readonly IToken _token;
        private readonly IStorageService _storageService;
        private readonly IAuthenticatedUserService _authenticatedUserService;
        public UpdateProfileCommandHandler(UserManager<Domain.Entities.User> userManager,IToken token,IAuthenticatedUserService authenticatedUserService, IStorageService storageService)
        {
            _userManager = userManager;
            _authenticatedUserService = authenticatedUserService;
            _token = token;
            _storageService = storageService;

        }
        public async Task<CommandResponse<TokenResponse>> Handle(UpdateProfileCommand request, CancellationToken cancellationToken)
        {
            var userId = _authenticatedUserService.GetCurrentUserId();
            var user = await _userManager.FindByIdAsync(userId.ToString());

            if (!string.IsNullOrEmpty(request.FirstName))
                user.FirstName = request.FirstName;
            if (!string.IsNullOrEmpty(request.LastName))
                user.LastName = request.LastName;
            if (request.Dob!=null)
                user.Dob = request.Dob;
            if (!string.IsNullOrEmpty(request.PhoneNumber))
                user.FirstName = request.PhoneNumber;
            if (request.Thumbnail != null)
                user.Thumbnail = await _storageService.SaveFile(request.Thumbnail, 0);

            var rs = await _userManager.UpdateAsync(user);
            if (rs.Succeeded)
                return new CommandResponse<TokenResponse>()
                {
                    Msg = "Update Profile OK",
                    Data = new TokenResponse()
                    {
                        Token = await _token.GenerateToken(user),
                        UserId = user.Id,
                        Username = user.Email

                    }
                };

            throw new CreateRequestException("UpdateProfile Failed");

        }
    }
}
