using Application.DTOs.Song;
using Application.DTOs.Song.SongRequest;
using Application.Exceptions;
using Application.Interfaces.Repo;
using Application.Interfaces.UoW;
using Application.Wrappers;
using Domain.Base;
using MediatR;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using ThirdPartyServices.Storage;

namespace Application.Features.Song.Commands
{
    public class UpdateCommand : SongUpdateRequest, IRequest<Response<Domain.Entities.Song>>
    {
        //[JsonIgnore]
        internal int Id { get; set; }
        public void SetId(int id)
        {
            Id = id;
        }
    }
    public class UpdateCommandHandler : IRequestHandler<UpdateCommand, Response<Domain.Entities.Song>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStorageService _storageService;
        public UpdateCommandHandler(IUnitOfWork unitOfWork, IStorageService storageService)
        {
            _unitOfWork = unitOfWork;
            _storageService = storageService;
        }

        public async Task<Response<Domain.Entities.Song>> Handle(UpdateCommand request, CancellationToken cancellationToken)
        {

            var song = await _unitOfWork.SongRepo.GetByIdAsync(request.Id);
            if (song == null)
                throw new NotFoundException("Song not found");
            if (!_unitOfWork.SongRepo.CheckAuthorizeResource(song))
                throw new UnauthorizeException();
            if (request.Name != null)
                song.Name = request.Name;
            if (request.Description != null)
                song.Description = request.Description;
            if (request.Duration != 0)
                song.Duration = request.Duration;
            if (request.Lyric != null)
                song.Lyric = await _storageService.SaveFile(request.Lyric,2);
            if (request.Thumbnail != null)
                song.Thumbnail = await _storageService.SaveFile(request.Thumbnail, 0);
            if (request.FileMusic != null)
                song.FileMusic = await _storageService.SaveFile(request.FileMusic, 1);

            var res =  _unitOfWork.SongRepo.Update(song);

            if (!_unitOfWork.Commit())
                throw new UpdateRequestException("update song fail");
            else
                return new CommandOK<Domain.Entities.Song>()
                {
                    ObjectId = song.Id,
                    Msg = "Update song OK",
                };
        }
    }
}
