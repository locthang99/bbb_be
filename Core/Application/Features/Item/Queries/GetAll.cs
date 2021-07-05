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
    public class GetAllQuery : PagedSortRequest, IRequest<PagedResponse<IEnumerable<ItemDTO>>>
    {
    }
    public class GetAllHandler : IRequestHandler<GetAllQuery, PagedResponse<IEnumerable<ItemDTO>>>
    {
        private readonly IUnitOfWork _uow;
        public GetAllHandler(IUnitOfWork uow)
        {
            _uow = uow;
        }
        public async Task<PagedResponse<IEnumerable<ItemDTO>>> Handle(GetAllQuery request, CancellationToken cancellationToken)
        {
            var res = await _uow.ItemRepo.GetAllPagedSortAsync(request);
            var data = res.Data.Select( s => new ItemDTO()
            { 
                Id = s.Id,
                Name = s.Name,
                Thumbnail = s.Thumbnail,
                Description = s.Description,
                DateCreate = s.DateCreate,
                Price = s.Price,
                Discount = s.Discount,
                AddTime = s.AddTime,

            }).ToList();
            return new PagedResponse<IEnumerable<ItemDTO>>(request)
            {
                TotalItem = res.TotallRecord,
                Data = data
            };
        }
    }
}
