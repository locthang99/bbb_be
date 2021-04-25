using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.DTOs.Tag;
using Application.Interfaces.Repo;
using Application.Parameters;
using Application.Wrappers;
using MediatR;

namespace Application.Features.Tag.Queries
{
    public class GetAllQuery :PagedSortRequest, IRequest<PagedResponse<IEnumerable<TagDTO>>>
    {
    }
    public class GetAllHandler : IRequestHandler<GetAllQuery, PagedResponse<IEnumerable<TagDTO>>>
    {
        private readonly ITagRepository _tagRepository;
        public GetAllHandler(ITagRepository tagRepository)
        {
            _tagRepository = tagRepository;
        }
        public async Task<PagedResponse<IEnumerable<TagDTO>>> Handle(GetAllQuery request, CancellationToken cancellationToken)
        {
            var res = await _tagRepository.GetAllPagedSortAsync(request);
            var data = res.Data.Select(s => _tagRepository.MapTag(s)).ToList();
            return new PagedResponse<IEnumerable<TagDTO>>(request) {
                TotalItem = res.TotallRecord,
                Data = data
            };
        }
    }
}
