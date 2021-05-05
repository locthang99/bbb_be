using Application.DTOs.User;
using Application.Exceptions;
using Application.Interfaces.Service;
using Application.Interfaces.UoW;
using Application.Parameters;
using Application.Wrappers;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.Account.EndUser.Commands
{
    public class UnFollowUserCommand : IRequest<Response<string>>
    {
        public int UserId { get; set; }
    }
    public class UnFollowUserHandler : IRequestHandler<UnFollowUserCommand, Response<string>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAuthenticatedUserService _authenticatedUserService;
        public UnFollowUserHandler(IUnitOfWork unitOfWork, IAuthenticatedUserService authenticatedUserService)
        {
            _unitOfWork = unitOfWork;
            _authenticatedUserService = authenticatedUserService;
        }
        public async Task<Response<string>> Handle(UnFollowUserCommand request, CancellationToken cancellationToken)
        {
            var userId = _authenticatedUserService.GetCurrentUserId();
            var res = await _unitOfWork.FollowerRepo.GetByTwoIdAsync(userId, request.UserId);

            if (res == null)
                return new Response<string>()
                {
                    Msg = "You dont follow this user"
                };
            else
            {
                _unitOfWork.FollowerRepo.Delete(res);
                if (_unitOfWork.Commit())
                    return new Response<string>()
                    {
                        Msg = "UnFollow OK"
                    };
            }
            throw new BadRequestException("UnFollow FAIL");
        }
    }
}
