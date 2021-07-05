using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.DTOs.Item;
using Application.Interfaces.Repo;
using Application.Interfaces.UoW;
using Application.Parameters;
using Application.Wrappers;
using MediatR;

namespace Application.Features.Item.Queries
{
    public class GetByIdQuery : IRequest<Response<ItemDTO>>
    {
        public int Id { get; set; }
    }
    public class GetByIdHandler : IRequestHandler<GetByIdQuery, Response<ItemDTO>>
    {
        private readonly IUnitOfWork _uow;
        public GetByIdHandler(IUnitOfWork uow)
        {
            _uow = uow;
        }
        public async Task<Response<ItemDTO>> Handle(GetByIdQuery request, CancellationToken cancellationToken)
        {
            var s = await _uow.ItemRepo.GetByIdAsync(request.Id);
            var data = new ItemDTO()
            {
                Id = s.Id,
                Name = s.Name,
                Thumbnail = s.Thumbnail,
                Description = s.Description,
                DateCreate = s.DateCreate,
                Price = s.Price,
                Discount = s.Discount,
                AddTime = s.AddTime
            };
            return new Response<ItemDTO>()
            {              
                Data = data
            };
        }
    }
}
