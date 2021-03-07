using Application.DTOs.Song;
using Application.DTOs.Song.SongRequest;
using Application.Interfaces.Repo;
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
        private readonly ISongRepository _songRepository;
        private readonly IStorageService _storageService;
        public DeleteCommandHandler(ISongRepository songRepository, IStorageService storageService)
        {
            _songRepository = songRepository;
            _storageService = storageService;
        }

        public async Task<Response<Domain.Entities.Song>> Handle(DeleteCommand request, CancellationToken cancellationToken)
        {

            var song = await _songRepository.GetByIdAsync(request.Id);
            if (song == null)
                return new NotFoundReponse<Domain.Entities.Song>();

            var res = await _songRepository.DeleteAsync(song);

            if (res == 0)
                return new CommandFail<Domain.Entities.Song>()
                {
                    Msg = "Delete song Failed"
                };
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
