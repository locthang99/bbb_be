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

namespace Application.Features.Rank.Queries
{
    public class GetTopSongQuery : PagedSortRequest, IRequest<PagedResponse<IEnumerable<SongDTO>>>
    {
    }
    public class GetTopSongHandler : IRequestHandler<GetTopSongQuery, PagedResponse<IEnumerable<SongDTO>>>
    {
        private readonly ISongRepository _songRepository;
        public GetTopSongHandler(ISongRepository songRepository)
        {
            _songRepository = songRepository;
        }
        public async Task<PagedResponse<IEnumerable<SongDTO>>> Handle(GetTopSongQuery request, CancellationToken cancellationToken)
        {
            var res = await _songRepository.FindByAsync(s=>s.Id==1,request);
            var data = res.Data.Select(s => _songRepository.MapSong(s)).ToList();
            return new PagedResponse<IEnumerable<SongDTO>>(request)
            {
                TotalItem = res.TotallRecord,
                Data = data
            };
        }
    }
}
