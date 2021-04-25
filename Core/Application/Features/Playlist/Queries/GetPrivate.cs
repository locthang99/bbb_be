using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.DTOs.PlayList;
using Application.Interfaces.Repo;
using Application.Interfaces.Service;
using Application.Parameters;
using Application.Wrappers;
using MediatR;

namespace Application.Features.Playlist.Queries
{
    public class GetPrivateQuery : PagedSortRequest, IRequest<PagedResponse<IEnumerable<PlaylistDTO>>>
    {
    }
    public class GetPrivateHandler : IRequestHandler<GetPrivateQuery, PagedResponse<IEnumerable<PlaylistDTO>>>
    {
        private readonly IPlaylistRepository _playlistRepository;
        public readonly IAuthenticatedUserService _authenticatedUserService;
        public GetPrivateHandler(IPlaylistRepository playlistRepository,IAuthenticatedUserService authenticatedUserService)
        {
            _playlistRepository = playlistRepository;
            _authenticatedUserService = authenticatedUserService;
        }
        public async Task<PagedResponse<IEnumerable<PlaylistDTO>>> Handle(GetPrivateQuery request, CancellationToken cancellationToken)
        {
            var userId = _authenticatedUserService.GetCurrentUserId();
            var res = await _playlistRepository.FindByAsync(s=> s.CreatedBy == userId,(request));
            var data = res.Data.ToList().Select(s => _playlistRepository.MapPlaylist(s)).ToList();
            return new PagedResponse<IEnumerable<PlaylistDTO>>(request)
            {
                TotalItem = res.TotallRecord,
                Data = data
            };
        }
    }
}
