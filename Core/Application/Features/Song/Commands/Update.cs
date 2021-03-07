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
    public class UpdateCommand : SongUpdateRequest, IRequest<Response<Domain.Entities.Song>>
    {
        [JsonIgnore]
        internal int Id { get; set; }
        public void SetId(int id)
        {
            Id = id;
        }
    }
    public class UpdateCommandHandler : IRequestHandler<UpdateCommand, Response<Domain.Entities.Song>>
    {
        private readonly ISongRepository _songRepository;
        private readonly IStorageService _storageService;
        public UpdateCommandHandler(ISongRepository songRepository, IStorageService storageService)
        {
            _songRepository = songRepository;
            _storageService = storageService;
        }

        public async Task<Response<Domain.Entities.Song>> Handle(UpdateCommand request, CancellationToken cancellationToken)
        {

            var song = await _songRepository.GetByIdAsync(request.Id);
            if (song == null)
                return new NotFoundReponse<Domain.Entities.Song>();

            if (request.Name != null)
                song.Name = request.Name;
            if (request.Description != null)
                song.Description = request.Description;
            if (request.Duration != 0)
                song.Duration = request.Duration;
            if (request.Lyric != null)
                song.Lyric = request.Lyric;
            if (request.Thumbnail != null)
                song.Thumbnail = await _storageService.SaveFile(request.Thumbnail, 0);
            if (request.FileMusic != null)
                song.FileMusic = await _storageService.SaveFile(request.FileMusic, 1);

            var res = await _songRepository.UpdateAsync(song);

            if (res == 0)
                return new CommandFail<Domain.Entities.Song>()
                {
                    Msg = "Update song Failed"
                };
            else
                return new CommandOK<Domain.Entities.Song>()
                {
                    ObjectId = song.Id,
                    Msg = "Update song OK",
                };
        }
    }
}
