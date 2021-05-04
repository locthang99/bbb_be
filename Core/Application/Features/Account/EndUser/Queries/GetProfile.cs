using Application.DTOs.User;
using Application.Interfaces.Repo;
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

namespace Application.Features.Account.EndUser.Queries
{
    public class GetProfileQuery : IRequest<CommandResponse<UserDTO>>
    {
    }
    public class GetProfileQueryHandler : IRequestHandler<GetProfileQuery, CommandResponse<UserDTO>>
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IAccountRepository _accountRepository;
        private readonly IAuthenticatedUserService _authenticatedUserService;
        public GetProfileQueryHandler(UserManager<User> userManager, IAccountRepository accountRepository,
            IAuthenticatedUserService authenticatedUserService)
        {
            _userManager = userManager;
            _accountRepository = accountRepository;
            _authenticatedUserService = authenticatedUserService;
        }
        public async Task<CommandResponse<UserDTO>> Handle(GetProfileQuery request, CancellationToken cancellationToken)
        {
            var userId =  _authenticatedUserService.GetCurrentUserId();
            var user = await  _accountRepository.GetByIdAsync(userId);
            var data = await _accountRepository.MapUserAsync(user);
            return new CommandOK<UserDTO>()
            {
                Msg = "GetProfile OK",
                Data = data
            };
        }
    }
}
