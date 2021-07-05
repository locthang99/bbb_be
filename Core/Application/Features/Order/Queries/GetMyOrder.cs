using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.DTOs.Order;
using Application.Interfaces.Repo;
using Application.Interfaces.Service;
using Application.Interfaces.UoW;
using Application.Parameters;
using Application.Wrappers;
using MediatR;

namespace Application.Features.Order.Queries
{
    public class GetMyOrderQuery : PagedSortRequest, IRequest<PagedResponse<IEnumerable<OrderDTO>>>
    {
    }
    public class GetMyOrderHandler : IRequestHandler<GetMyOrderQuery, PagedResponse<IEnumerable<OrderDTO>>>
    {
        private readonly IUnitOfWork _uow;
        private readonly IAuthenticatedUserService _authenService;
        public GetMyOrderHandler(IUnitOfWork uow,IAuthenticatedUserService authenService)
        {
            _uow = uow;
            _authenService = authenService;

        }
        public async Task<PagedResponse<IEnumerable<OrderDTO>>> Handle(GetMyOrderQuery request, CancellationToken cancellationToken)
        {
            var userId = _authenService.GetCurrentUserId();
            var res = await _uow.OrderRepo.FindByAsync(x=>x.UserId == userId,request);
            var data = res.Data.ToList().Select(s => new OrderDTO()
            {
                UserId = s.UserId,
                Amount = s.Amount,
                ItemId = s.ItemId,
                Name = s.Name,
                DateCreate = s.DateCreate,
                ItemName = _uow.ItemRepo.GetById(s.ItemId).Name,
                DiscountAdded = s.DiscountAdded,
                Status = s.Status
            }).ToList();
            return new PagedResponse<IEnumerable<OrderDTO>>(request)
            {
                TotalItem = res.TotallRecord,
                Data = data
            };
        }
    }
}
