using Application.Exceptions;
using Application.Interfaces.Repo;
using Application.Interfaces.RepoBase;
using Application.Wrappers;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.Song.Commands
{
    public class UpdateTypeCommand : IRequest<Response<string>>
    {
        public int Id { get; set; }
        public int IdTypeUpdate { get; set; }

        public void SetId(int id,int idType)
        {
            Id = id;
            IdTypeUpdate = idType;
        }
    }

    public class UpdateTypeHandler : IRequestHandler<UpdateTypeCommand, Response<string>>
    {
        private readonly ISongRepository _songRepository;
        private readonly IExtensionEntityRepository<Song_SongType> _song_typeRepo;
        public UpdateTypeHandler(ISongRepository songRepository,IExtensionEntityRepository<Song_SongType> song_typeRepo)
        {
            _songRepository = songRepository;
            _song_typeRepo = song_typeRepo;
        }
        
        public async Task<Response<string>> Handle(UpdateTypeCommand request, CancellationToken cancellationToken)
        {
            if(request.IdTypeUpdate==0)
                throw new BadRequestException("Id type not equal 0");
            var song = await _songRepository.GetByIdAsync(request.Id);
            if (song == null)
                throw new NotFoundException("Song not found");
            if (!_songRepository.CheckAuthorizeResource(song))
                throw new UnauthorizeException();
            if (request.IdTypeUpdate > 0)
            {
                var type = await _song_typeRepo.GetByTwoIdAsync(request.Id, request.IdTypeUpdate);
                if (type != null)
                    throw new BadRequestException("This type have been added to this song");
                var rs = await _song_typeRepo.AddAsync(new Song_SongType() { SongId = request.Id, SongTypeId = request.IdTypeUpdate });
                if (rs != null)
                    return new CommandOK<string>()
                    {
                        Msg = "Add type OK"
                    };
            }
            if (request.IdTypeUpdate < 0)
            {
                var type = await _song_typeRepo.GetByTwoIdAsync(request.Id, -request.IdTypeUpdate);
                if (type == null)
                    throw new BadRequestException("The song dont has this type");
                var rs = await _song_typeRepo.DeleteAsync(type);
                if(rs>0)
                    return new CommandOK<string>()
                    {
                        Msg = "Remove type OK"
                    };
            }
            return new CommandFail<string>()
            {
                Code = 400,
                Msg = "Update Fail",
            };

        }
    }
}
