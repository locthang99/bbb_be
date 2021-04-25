using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.DTOs.Song;
using Application.Interfaces.Repo;
using Application.Interfaces.Service;
using Application.Parameters;
using Application.Wrappers;
using MediatR;

namespace Application.Features.Song.Queries
{
    public class GetPrivateQuery : PagedSortRequest, IRequest<PagedResponse<IEnumerable<SongDTO>>>
    {
    }
    public class GetPrivateHandler : IRequestHandler<GetPrivateQuery, PagedResponse<IEnumerable<SongDTO>>>
    {
        private readonly ISongRepository _songRepository;
        public readonly IAuthenticatedUserService _authenticatedUserService;
        public GetPrivateHandler(ISongRepository songRepository,IAuthenticatedUserService authenticatedUserService)
        {
            _songRepository = songRepository;
            _authenticatedUserService = authenticatedUserService;
        }
        public async Task<PagedResponse<IEnumerable<SongDTO>>> Handle(GetPrivateQuery request, CancellationToken cancellationToken)
        {
            var userId = _authenticatedUserService.GetCurrentUserId();
            var res = await _songRepository.FindByAsync(s=> s.CreatedBy == userId,(request));
            var data = res.Data.ToList().Select(s => _songRepository.MapSong(s)).ToList();
            return new PagedResponse<IEnumerable<SongDTO>>(request)
            {
                TotalItem = res.TotallRecord,
                Data = data
            };
        }
    }
}
