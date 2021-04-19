using Application.DTOs.Song;
using Application.DTOs.Song.SongRequest;
using Application.Interfaces.Repo;
using Application.Wrappers;
using Domain.Base;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ThirdPartyServices.Storage;
using System.Net.Http;
using Newtonsoft.Json;
using System.Linq;

namespace Application.Features.Song.Commands
{
    public class CreateCommand : SongCreateRequest, IRequest<CommandResponse<TypeFromML>>
    {

    }
    public class CreateCommandHandler : IRequestHandler<CreateCommand, CommandResponse<TypeFromML>>
    {
        private readonly ISongRepository _songRepository;
        private readonly IStorageService _storageService;
        private readonly IHttpClientFactory _httpClientFactoty;
        public CreateCommandHandler(ISongRepository songRepository, IStorageService storageService, IHttpClientFactory httpClientFactoty)
        {
            _songRepository = songRepository;
            _storageService = storageService;
            _httpClientFactoty = httpClientFactoty;
        }

        public async Task<CommandResponse<TypeFromML>> Handle(CreateCommand request, CancellationToken cancellationToken)
        {
            var song = new Domain.Entities.Song()
            {
                Name = request.Name,
                Description = request.Description,
                Duration = request.Duration,
                IsPublic = request.IsPublic,
                Thumbnail = await _storageService.SaveFile(request.Thumbnail, 0),
                FileMusic = await _storageService.SaveFile(request.FileMusic, 1)
            };

            var res = await _songRepository.AddAsync(song);

            var rs = await _httpClientFactoty.CreateClient().GetAsync("http://localhost:8089/predict/?"+song.FileMusic);
            rs.EnsureSuccessStatusCode();
            var resp = await rs.Content.ReadAsStringAsync();
            var obj =  JsonConvert.DeserializeObject<TypeFromML>(resp);

            if (res == null)
                return new CommandFail<TypeFromML>()
                {
                    Msg = "Create song Failed"
                };
            else
                return new CommandOK<TypeFromML>()
                {
                    ObjectId = res.Id,
                    Data = obj,
                };
        }
    }
    public class TypeFromML : RealEntity
    {
        public string reggae { get; set; }
        public string classical { get; set; }
        public string country { get; set; }
        public string pop { get; set; }
        public string disco { get; set; }
        public string jazz { get; set; }
        public string rock { get; set; }
        public string metal { get; set; }
        public string hiphop { get; set; }
        public string blues { get; set; }
    }
}
