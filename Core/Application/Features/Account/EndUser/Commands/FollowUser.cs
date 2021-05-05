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
    public class FollowUserCommand : IRequest<Response<string>>
    {
        public int UserId { get; set; }
    }
    public class FollowUserHandler : IRequestHandler<FollowUserCommand, Response<string>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAuthenticatedUserService _authenticatedUserService;
        public FollowUserHandler(IUnitOfWork unitOfWork, IAuthenticatedUserService authenticatedUserService)
        {
            _unitOfWork = unitOfWork;
            _authenticatedUserService = authenticatedUserService;
        }
        public async Task<Response<string>> Handle(FollowUserCommand request, CancellationToken cancellationToken)
        {
            var userId = _authenticatedUserService.GetCurrentUserId();
            var res = await _unitOfWork.FollowerRepo.GetByTwoIdAsync(userId,request.UserId);
            
            if(res != null)
                return new Response<string>()
                {
                    Msg = "You have followed this user"
                };
            else
            {
                await _unitOfWork.FollowerRepo.AddAsync(new Follower() { SubscriberId = userId, PublisherId = request.UserId });
                if (_unitOfWork.Commit())
                    return new Response<string>()
                    {
                        Msg = "Follow OK"
                    };
            }
            throw new BadRequestException("Follow FAIL");
        }
    }
}
