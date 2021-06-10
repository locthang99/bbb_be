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
    public class StrongDeleteCommand : IRequest<Response<Domain.Entities.Song>>
    {
        [JsonIgnore]
        internal int Id { get; set; }
        public void SetId(int id)
        {
            Id = id;
        }
    }
    public class StrongDeleteCommandHandler : IRequestHandler<StrongDeleteCommand, Response<Domain.Entities.Song>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStorageService _storageService;
        public StrongDeleteCommandHandler(IUnitOfWork unitOfWork, IStorageService storageService)
        {
            _unitOfWork = unitOfWork;
            _storageService = storageService;
        }

        public async Task<Response<Domain.Entities.Song>> Handle(StrongDeleteCommand request, CancellationToken cancellationToken)
        {

            var song = await _unitOfWork.SongRepo.GetByIdAsync(request.Id);
            if (song == null)
                throw new NotFoundException("Song not found");
            if (!_unitOfWork.SongRepo.CheckAuthorizeResource(song))
                throw new UnauthorizeException();
            var res = _unitOfWork.SongRepo.StrongDelete(song);

            if (!_unitOfWork.Commit())
                throw new DeleteRequestException("StrongDelete fail");
            else
            {
                //await _storageService.StrongDeleteFileAsync(song.Thumbnail, 0);
                //await _storageService.StrongDeleteFileAsync(song.FileMusic, 1);
                return new CommandOK<Domain.Entities.Song>()
                {
                    ObjectId = song.Id,
                    Msg = "StrongDelete song OK",
                };
            }
        }
    }
}
