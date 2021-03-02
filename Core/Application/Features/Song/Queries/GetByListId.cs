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
    public class GetByListIdQuery : PagedSortRequest, IRequest<PagedResponse<IEnumerable<SongDTO>>>
    {
       public IReadOnlyList<int> listId { get; set; }
    }
    public class GetByListIdHandler : IRequestHandler<GetByListIdQuery, PagedResponse<IEnumerable<SongDTO>>>
    {
        private readonly ISongRepository _songRepository;
        public GetByListIdHandler(ISongRepository songRepository)
        {
            _songRepository = songRepository;
        }
        public async Task<PagedResponse<IEnumerable<SongDTO>>> Handle(GetByListIdQuery request, CancellationToken cancellationToken)
        {
            var res = await _songRepository.GetByListIdPagedSortAsync(request.listId,request);
            var data = res.Select(s => _songRepository.MapSong(s)).ToList();
            return new PagedResponse<IEnumerable<SongDTO>>
            {
                Code = 200,
                Msg = "Get Song by list id Ok",
                PageSize = request.PageSize,
                Index = request.Index,
                Data = data
            };
        }
    }
}
