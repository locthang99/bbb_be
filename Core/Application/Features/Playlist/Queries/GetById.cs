using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.DTOs.PlayList;
using Application.Exceptions;
using Application.Interfaces.Repo;
using Application.Parameters;
using Application.Wrappers;
using MediatR;

namespace Application.Features.Playlist.Queries
{
    public class GetByIdQuery : IRequest<Response<PlaylistDTO>>
    {
        public int Id { get; set; }
    }
    public class GetByIdHandler : IRequestHandler<GetByIdQuery, Response<PlaylistDTO>>
    {
        private readonly IPlaylistRepository _playlistRepository;
        public GetByIdHandler(IPlaylistRepository playlistRepository)
        {
            _playlistRepository = playlistRepository;
        }
        public async Task<Response<PlaylistDTO>> Handle(GetByIdQuery request, CancellationToken cancellationToken)
        {
            var res = await _playlistRepository.GetByIdAsync(request.Id);
            if (res == null)
                throw new NotFoundException("Playlist not found");
                //return new NotFoundReponse<PlaylistDTO>();

            var data = _playlistRepository.MapPlaylist(res);
            return new Response<PlaylistDTO>()
            {
                Data = data
            };
        }


    }
}
