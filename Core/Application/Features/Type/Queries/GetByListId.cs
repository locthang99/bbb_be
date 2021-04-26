﻿using System;
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
    public class GetByListIdQuery : PagedSortRequest, IRequest<PagedResponse<IEnumerable<TypeDTO>>>
    {
       public IReadOnlyList<int> listId { get; set; }
    }
    public class GetByListIdHandler : IRequestHandler<GetByListIdQuery, PagedResponse<IEnumerable<TypeDTO>>>
    {
        private readonly ITypeRepository _typeRepository;
        public GetByListIdHandler(ITypeRepository typeRepository)
        {
            _typeRepository = typeRepository;
        }
        public async Task<PagedResponse<IEnumerable<TypeDTO>>> Handle(GetByListIdQuery request, CancellationToken cancellationToken)
        {
            var res = await _typeRepository.GetByListIdPagedSortAsync(request.listId,request);
            var data = res.Data.Select(s => _typeRepository.MapType(s)).ToList();
            return new PagedResponse<IEnumerable<TypeDTO>>(request)
            {
                TotalItem = res.TotallRecord,
                Data = data
            };
        }
    }
}
