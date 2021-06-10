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
    public class GetListDeletedQuery : PagedSortRequest, IRequest<PagedResponse<IEnumerable<TagDTO>>>
    {
        public string Name { get; set; }
    }
    public class GetListDeletedHandler : IRequestHandler<GetListDeletedQuery, PagedResponse<IEnumerable<TagDTO>>>
    {
        private readonly ITagRepository _TagRepository;
        public GetListDeletedHandler(ITagRepository TagRepository)
        {
            _TagRepository = TagRepository;
        }
        public async Task<PagedResponse<IEnumerable<TagDTO>>> Handle(GetListDeletedQuery request, CancellationToken cancellationToken)
        {
            var res = await _TagRepository.GetByListDeletedSortAsync(request.Name, request);
            var data = res.Data.Select(s => _TagRepository.MapTag(s)).ToList();
            return new PagedResponse<IEnumerable<TagDTO>>(request)
            {
                TotalItem = res.TotallRecord,
                Data = data
            };
        }
    }
}
