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
    public class UpdateTagCommand : IRequest<Response<string>>
    {
        public int Id { get; set; }
        public int IdTagUpdate { get; set; }

        public void SetId(int id, int idTag)
        {
            Id = id;
            IdTagUpdate = idTag;
        }
    }

    public class UpdateTagHandler : IRequestHandler<UpdateTagCommand, Response<string>>
    {
        private readonly ISongRepository _songRepository;
        private readonly IExtensionEntityRepository<Song_Tag> _song_tagRepo;
        public UpdateTagHandler(ISongRepository songRepository, IExtensionEntityRepository<Song_Tag> song_tagRepo)
        {
            _songRepository = songRepository;
            _song_tagRepo = song_tagRepo;
        }

        public async Task<Response<string>> Handle(UpdateTagCommand request, CancellationToken cancellationToken)
        {
            if (request.IdTagUpdate == 0)
                throw new BadRequestException("Id tag not equal 0");
            var song = await _songRepository.GetByIdAsync(request.Id);
            if (song == null)
                throw new NotFoundException("Song not found");
            if (!_songRepository.CheckAuthorizeResource(song))
                throw new UnauthorizeException();
            if (request.IdTagUpdate > 0)
            {
                var tag = await _song_tagRepo.GetByTwoIdAsync(request.Id, request.IdTagUpdate);
                if (tag != null)
                    throw new BadRequestException("This tag have been added to this song");
                var rs = await _song_tagRepo.AddAsync(new Song_Tag() { SongId = request.Id, TagId = request.IdTagUpdate });
                if (rs != null)
                    return new CommandOK<string>()
                    {
                        Msg = "Add tag OK"
                    };
            }
            if (request.IdTagUpdate < 0)
            {
                var tag = await _song_tagRepo.GetByTwoIdAsync(request.Id, -request.IdTagUpdate);
                if (tag == null)
                    throw new BadRequestException("The song dont has this tag");
                var rs = await _song_tagRepo.DeleteAsync(tag);
                if (rs > 0)
                    return new CommandOK<string>()
                    {
                        Msg = "Remove tag OK"
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
