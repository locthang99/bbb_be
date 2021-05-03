using Application.DTOs.User;
using Application.Interfaces.Service;
using Application.Interfaces.UoW;
using Application.Parameters;
using Application.Wrappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.Account.EndUser.Queries
{
    public class GetRecommendPublicerQuery : PagedSortRequest, IRequest<PagedResponse<IEnumerable<FollowerDTO>>>
    {
    }
    public class GetRecommendPublicerHandler : IRequestHandler<GetRecommendPublicerQuery, PagedResponse<IEnumerable<FollowerDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAuthenticatedUserService _authenticatedUserService;
        public GetRecommendPublicerHandler(IUnitOfWork unitOfWork, IAuthenticatedUserService authenticatedUserService)
        {
            _unitOfWork = unitOfWork;
            _authenticatedUserService = authenticatedUserService;
        }
        public async Task<PagedResponse<IEnumerable<FollowerDTO>>> Handle(GetRecommendPublicerQuery request, CancellationToken cancellationToken)
        {
            var userId = _authenticatedUserService.GetCurrentUserId();
            var res = await _unitOfWork.FollowerRepo.FindByAsync(x => x.SubscriberId == userId, request);
            var data = res.Data.Select(u => new FollowerDTO()
            {
                UserID = u.SubscriberId,
                FirstName = u.Subscriber.FirstName,
                LastName = u.Subscriber.LastName,
                Status = "YouFollowing",
                TotalFollower = u.Subscriber.TotalFollower,
                DateCreate = u.DateCreate
            }).ToList();
            return new PagedResponse<IEnumerable<FollowerDTO>>(request)
            {
                TotalItem = res.TotallRecord,
                Data = data
            };
        }
    }
}
