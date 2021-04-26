using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.DTOs.Type;
using Application.Interfaces.Repo;
using Application.Parameters;
using Application.Wrappers;
using MediatR;

namespace Application.Features.Type.Queries
{
    public class GetByNameQuery : PagedSortRequest, IRequest<PagedResponse<IEnumerable<TypeDTO>>>
    {
        public string Name { get; set; }
    }
    public class GetByNameHandler : IRequestHandler<GetByNameQuery, PagedResponse<IEnumerable<TypeDTO>>>
    {
        private readonly ITypeRepository _typeRepository;
        public GetByNameHandler(ITypeRepository typeRepository)
        {
            _typeRepository = typeRepository;
        }
        public async Task<PagedResponse<IEnumerable<TypeDTO>>> Handle(GetByNameQuery request, CancellationToken cancellationToken)
        {
            var res = await _typeRepository.GetByNamePagedSortAsync(request.Name,request);
            var data = res.Data.Select(s => _typeRepository.MapType(s)).ToList();
            return new PagedResponse<IEnumerable<TypeDTO>>(request)
            {
                TotalItem = res.TotallRecord,
                Data = data
            };
        }
    }
}
