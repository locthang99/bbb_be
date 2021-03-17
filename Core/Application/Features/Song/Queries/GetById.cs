using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.DTOs.Song;
using Application.Exceptions;
using Application.Interfaces.Repo;
using Application.Parameters;
using Application.Wrappers;
using MediatR;

namespace Application.Features.Song.Queries
{
    public class GetByIdQuery : IRequest<Response<SongDTO>>
    {
        public int Id { get; set; }
    }
    public class GetByIdHandler : IRequestHandler<GetByIdQuery, Response<SongDTO>>
    {
        private readonly ISongRepository _songRepository;
        public GetByIdHandler(ISongRepository songRepository)
        {
            _songRepository = songRepository;
        }
        public async Task<Response<SongDTO>> Handle(GetByIdQuery request, CancellationToken cancellationToken)
        {
            if (request.Id == 500)
                throw new BadRequestException("Bad");
            var res = await _songRepository.GetByIdAsync(request.Id);
            if (res == null)
                throw new NotFoundException("Song not found");
                //return new NotFoundReponse<SongDTO>();

            var data = _songRepository.MapSong(res);
            return new Response<SongDTO>()
            {
                Data = data
            };
        }


    }
}
