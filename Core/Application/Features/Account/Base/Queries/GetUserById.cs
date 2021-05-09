using Application.DTOs.User;
using Application.Interfaces.Service;
using Application.Interfaces.UoW;
using Application.Parameters;
using Application.Wrappers;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.Account.Base.Queries
{
    public class GetUserByIdQuery : IRequest<Response<UserDTO>>
    {
        public int UserId { get; set; }
    }
    public class GetUserByIdHandler : IRequestHandler<GetUserByIdQuery, Response<UserDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public GetUserByIdHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Response<UserDTO>> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            //var userId = _authenticatedUserService.GetCurrentUserId();
            var user = await _unitOfWork.AccountRepo.GetByIdAsync(request.UserId);
            var data = _unitOfWork.AccountRepo.MapUser(user);

            return new Response<UserDTO>()
            {
                Data = data
            };
        }
    }
}
