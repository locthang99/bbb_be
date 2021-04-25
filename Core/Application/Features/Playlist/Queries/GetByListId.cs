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
    public class GetByListIdQuery : PagedSortRequest, IRequest<PagedResponse<IEnumerable<PlaylistDTO>>>
    {
       public IReadOnlyList<int> listId { get; set; }
    }
    public class GetByListIdHandler : IRequestHandler<GetByListIdQuery, PagedResponse<IEnumerable<PlaylistDTO>>>
    {
        private readonly IPlaylistRepository _playlistRepository;
        public GetByListIdHandler(IPlaylistRepository playlistRepository)
        {
            _playlistRepository = playlistRepository;
        }
        public async Task<PagedResponse<IEnumerable<PlaylistDTO>>> Handle(GetByListIdQuery request, CancellationToken cancellationToken)
        {
            var res = await _playlistRepository.GetByListIdPagedSortAsync(request.listId,request);
            var data = res.Data.Select(s => _playlistRepository.MapPlaylist(s)).ToList();
            return new PagedResponse<IEnumerable<PlaylistDTO>>(request)
            {
                TotalItem = res.TotallRecord,
                Data = data
            };
        }
    }
}
