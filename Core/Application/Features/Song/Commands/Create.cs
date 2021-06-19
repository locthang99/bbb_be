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
                IsOfficial = request.IsOfficial,
                Country = request.Country,
               
            };
            if (request.Thumbnail != null)
                song.Thumbnail = await _storageService.SaveFile(request.Thumbnail, 0);

            if (request.Lyric != null)
                song.Lyric = await _storageService.SaveFile(request.Lyric, 2);

            if (request.FileMusic128 != null)
                song.FileMusic128 = await _storageService.SaveFile(request.FileMusic128, 1);

            if (request.FileMusic320 != null)
                song.FileMusic320 = await _storageService.SaveFile(request.FileMusic320, 1);

            if (request.FileMusicLossless != null)
                song.FileMusicLossless = await _storageService.SaveFile(request.FileMusicLossless, 1);

            var res = await _unitOfWork.SongRepo.AddAsync(song);

            if (!_unitOfWork.Commit())
            {
                return new CommandFail<Domain.Entities.Song>()
                {
                    Msg = "Create song Failed"
                };
            }    

            else
                return new CommandOK<Domain.Entities.Song>()
                {
                    ObjectId = res.Id,
                    Data = res,
                };
        }

    }

}
