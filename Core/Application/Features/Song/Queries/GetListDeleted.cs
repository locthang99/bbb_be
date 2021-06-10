using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.DTOs.Song;
using Application.Interfaces.Repo;
using Application.Parameters;
using Application.Wrappers;
using MediatR;

namespace Application.Features.Song.Queries
{
    public class GetListDeletedQuery : PagedSortRequest, IRequest<PagedResponse<IEnumerable<SongDTO>>>
    {
        public string Name { get; set; }
    }
    public class GetListDeletedHandler : IRequestHandler<GetListDeletedQuery, PagedResponse<IEnumerable<SongDTO>>>
    {
        private readonly ISongRepository _songRepository;
        public GetListDeletedHandler(ISongRepository songRepository)
        {
            _songRepository = songRepository;
        }
        public async Task<PagedResponse<IEnumerable<SongDTO>>> Handle(GetListDeletedQuery request, CancellationToken cancellationToken)
        {
            var res = await _songRepository.GetByListDeletedSortAsync(request.Name, request);
            var data = res.Data.Select(s => _songRepository.MapSong(s)).ToList();
            return new PagedResponse<IEnumerable<SongDTO>>(request)
            {
                TotalItem = res.TotallRecord,
                Data = data
            };
        }
    }
}
