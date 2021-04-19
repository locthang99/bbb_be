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
    public class DeleteCommand : IRequest<Response<Domain.Entities.Song>>
    {
        [JsonIgnore]
        internal int Id { get; set; }
        public void SetId(int id)
        {
            Id = id;
        }
    }
    public class DeleteCommandHandler : IRequestHandler<DeleteCommand, Response<Domain.Entities.Song>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStorageService _storageService;
        public DeleteCommandHandler(IUnitOfWork unitOfWork, IStorageService storageService)
        {
            _unitOfWork = unitOfWork;
            _storageService = storageService;
        }

        public async Task<Response<Domain.Entities.Song>> Handle(DeleteCommand request, CancellationToken cancellationToken)
        {

            var song = await _unitOfWork.SongRepo.GetByIdAsync(request.Id);
            if (song == null)
                throw new NotFoundException("Song not found");

            var res =  _unitOfWork.SongRepo.Delete(song);

            if (_unitOfWork.Commit()==0)
                throw new DeleteRequestException("Delete fail");
            else
            {
                await _storageService.DeleteFileAsync(song.Thumbnail, 0);
                await _storageService.DeleteFileAsync(song.FileMusic, 1);
                return new CommandOK<Domain.Entities.Song>()
                {
                    ObjectId = song.Id,
                    Msg = "Delete song OK",
                };
            }
        }
    }
}
