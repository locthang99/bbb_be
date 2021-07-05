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
    public class GetByIdQuery : IRequest<Response<OrderDTO>>
    {
        public int Id { get; set; }
    }
    public class GetByIdHandler : IRequestHandler<GetByIdQuery, Response<OrderDTO>>
    {
        private readonly IUnitOfWork _uow;
        public GetByIdHandler(IUnitOfWork uow)
        {
            _uow = uow;
        }
        public async Task<Response<OrderDTO>> Handle(GetByIdQuery request, CancellationToken cancellationToken)
        {
            var s = await _uow.OrderRepo.GetByIdAsync(request.Id);
            var data = new OrderDTO()
            {
                UserId = s.UserId,
                Amount = s.Amount,
                ItemId = s.ItemId,
                Name = s.Name,
                DateCreate = s.DateCreate,
                ItemName = _uow.ItemRepo.GetById(s.ItemId).Name,
                DiscountAdded = s.DiscountAdded,
                Status = s.Status
            };
            return new Response<OrderDTO>()
            {              
                Data = data
            };
        }
    }
}
