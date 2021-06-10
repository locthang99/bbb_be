using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.DTOs.PlayList;
using Application.Interfaces.Repo;
using Application.Parameters;
using Application.Wrappers;
using MediatR;

namespace Application.Features.Playlist.Queries
{
    public class GetDeletedlQuery : PagedSortRequest, IRequest<PagedResponse<IEnumerable<PlaylistDTO>>>
    {
        public string Name { get; set; }
    }
    public class GetDeletedlHandler : IRequestHandler<GetDeletedlQuery, PagedResponse<IEnumerable<PlaylistDTO>>>
    {
        private readonly IPlaylistRepository _playlistRepository;
        public GetDeletedlHandler(IPlaylistRepository playlistRepository)
        {
            _playlistRepository = playlistRepository;
        }
        public async Task<PagedResponse<IEnumerable<PlaylistDTO>>> Handle(GetDeletedlQuery request, CancellationToken cancellationToken)
        {
            var res = await _playlistRepository.GetByListDeletedSortAsync(request.Name,request);
            var data = res.Data.Select(s => _playlistRepository.MapPlaylist(s)).ToList();
            return new PagedResponse<IEnumerable<PlaylistDTO>>(request)
            {
                TotalItem = res.TotallRecord,
                Data = data
            };
        }
    }
}
