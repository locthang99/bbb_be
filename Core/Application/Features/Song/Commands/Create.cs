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
using Application.Interfaces.UoW;

namespace Application.Features.Song.Commands
{
    public class CreateCommand : SongCreateRequest, IRequest<CommandResponse<Domain.Entities.Song>>
    {

    }
    public class CreateCommandHandler : IRequestHandler<CreateCommand, CommandResponse<Domain.Entities.Song>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStorageService _storageService;
        private readonly IHttpClientFactory _httpClientFactoty;
        public CreateCommandHandler(IUnitOfWork unitOfWork, IStorageService storageService, IHttpClientFactory httpClientFactoty)
        {
            _unitOfWork = unitOfWork;
            _storageService = storageService;
            _httpClientFactoty = httpClientFactoty;
        }

        public async Task<CommandResponse<Domain.Entities.Song>> Handle(CreateCommand request, CancellationToken cancellationToken)
        {
            var song = new Domain.Entities.Song()
            {
                Name = request.Name,
                Description = request.Description,
                Duration = request.Duration,
                IsPublic = request.IsPublic,
                Lyric = await _storageService.SaveFile(request.Lyric, 2),
                Thumbnail = await _storageService.SaveFile(request.Thumbnail, 0),
                FileMusic = await _storageService.SaveFile(request.FileMusic, 1)
            };

            var res = await _unitOfWork.SongRepo.AddAsync(song);

            //var rs = await _httpClientFactoty.CreateClient().GetAsync("http://localhost:8089/predict/?"+song.FileMusic);
            //rs.EnsureSuccessStatusCode();
            //var resp = await rs.Content.ReadAsStringAsync();
            //var obj =  JsonConvert.DeserializeObject<Domain.Entities.Song>(resp);

            if (!_unitOfWork.Commit())
                return new CommandFail<Domain.Entities.Song>()
                {
                    Msg = "Create song Failed"
                };
            else
                return new CommandOK<Domain.Entities.Song>()
                {
                    ObjectId = res.Id,
                    Data = res,
                };
        }
    }
    public class Type : RealEntity
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
