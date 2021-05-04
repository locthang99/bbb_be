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

namespace Application.Features.Account.Admin.Queries
{
    public class GetProfileCommand : IRequest<CommandResponse<UserDTO>>
    {
    }
    public class GetProfileCommandHandler : IRequestHandler<GetProfileCommand, CommandResponse<UserDTO>>
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IAccountRepository _accountRepository;
        private readonly IAuthenticatedUserService _authenticatedUserService;
        public GetProfileCommandHandler(UserManager<User> userManager, IAccountRepository accountRepository,
            IAuthenticatedUserService authenticatedUserService)
        {
            _userManager = userManager;
            _accountRepository = accountRepository;
            _authenticatedUserService = authenticatedUserService;
        }
        public async Task<CommandResponse<UserDTO>> Handle(GetProfileCommand request, CancellationToken cancellationToken)
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
