using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.DTOs.Order;
using Application.Interfaces.Repo;
using Application.Interfaces.UoW;
using Application.Parameters;
using Application.Wrappers;
using MediatR;

namespace Application.Features.Order.Queries
{
    public class GetAllQuery : PagedSortRequest, IRequest<PagedResponse<IEnumerable<OrderDTO>>>
    {
    }
    public class GetAllHandler : IRequestHandler<GetAllQuery, PagedResponse<IEnumerable<OrderDTO>>>
    {
        private readonly IUnitOfWork _uow;
        public GetAllHandler(IUnitOfWork uow)
        {
            _uow = uow;
        }
        public async Task<PagedResponse<IEnumerable<OrderDTO>>> Handle(GetAllQuery request, CancellationToken cancellationToken)
        {
            var res = await _uow.OrderRepo.GetAllPagedSortAsync(request);
            var data = res.Data.Select( s => new OrderDTO()
            { 
                UserId = s.UserId,
                Amount = s.Amount,
                ItemId = s.ItemId,
                Name = s.Name,
                DateCreate = s.DateCreate,
                ItemName =  _uow.ItemRepo.GetById(s.ItemId).Name,
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
