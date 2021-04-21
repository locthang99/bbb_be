using Application.Exceptions;
using Application.Interfaces.Repo;
using Application.Interfaces.RepoBase;
using Application.Interfaces.UoW;
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
        private readonly IUnitOfWork _unitOfWork;
        public UpdateTagHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Response<string>> Handle(UpdateTagCommand request, CancellationToken cancellationToken)
        {
            if (request.IdTagUpdate == 0)
                throw new BadRequestException("Id tag not equal 0");
            var song = await _unitOfWork.SongRepo.GetByIdAsync(request.Id);
            if (song == null)
                throw new NotFoundException("Song not found");
            var tag = await _unitOfWork.TagRepo.GetByIdAsync(Math.Abs(request.IdTagUpdate));
            if (tag == null)
                throw new NotFoundException("Tag not found");
            if (!_unitOfWork.SongRepo.CheckAuthorizeResource(song))
                throw new UnauthorizeException();
            if (request.IdTagUpdate > 0)
            {
                var song_tag = await _unitOfWork.Song_TagRepo.GetByTwoIdAsync(request.Id, request.IdTagUpdate);
                if (song_tag != null)
                    throw new BadRequestException("This tag have been added to this song");
                var rs = await _unitOfWork.Song_TagRepo.AddAsync(new Song_Tag() { SongId = request.Id, TagId = request.IdTagUpdate });
                if (_unitOfWork.Commit())
                    return new CommandOK<string>()
                    {
                        Msg = "Add tag OK"
                    };
            }
            if (request.IdTagUpdate < 0)
            {
                var song_tag = await _unitOfWork.Song_TagRepo.GetByTwoIdAsync(request.Id, -request.IdTagUpdate);
                if (song_tag == null)
                    throw new BadRequestException("The song dont has this tag");
                var rs =  _unitOfWork.Song_TagRepo.Delete(song_tag);
                if (_unitOfWork.Commit())
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
