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
    public class GetAllQuery :PagedSortRequest, IRequest<PagedResponse<IEnumerable<SongDTO>>>
    {
    }
    public class GetAllHandler : IRequestHandler<GetAllQuery, PagedResponse<IEnumerable<SongDTO>>>
    {
        private readonly ISongRepository _songRepository;
        public GetAllHandler(ISongRepository songRepository)
        {
            _songRepository = songRepository;
        }
        public async Task<PagedResponse<IEnumerable<SongDTO>>> Handle(GetAllQuery request, CancellationToken cancellationToken)
        {
            var res = await _songRepository.GetAllPagedSortAsync(request);
            var data = res.Select(s => _songRepository.MapSong(s)).ToList();
            return new PagedResponse<IEnumerable<SongDTO>> {
                Code = 200,
                Msg = "Get Song Ok",
                PageSize = request.PageSize,
                Index = request.Index  ,
                Data = data
            };
        }
    }
}
