using Application.DTOs.PlayList;
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
using Application.DTOs.PlayList.PlayListRequest;
using Application.Interfaces.Service;
using Application.Enum;

namespace Application.Features.Playlist.Commands
{
    public class CreateCommand : PlayListCreateRequest, IRequest<CommandResponse<Domain.Entities.Playlist>>
    {

    }
    public class CreateCommandHandler : IRequestHandler<CreateCommand, CommandResponse<Domain.Entities.Playlist>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStorageService _storageService;
        private readonly IHttpClientFactory _httpClientFactoty;
        public readonly IAuthenticatedUserService _authenticatedUserService;
        public CreateCommandHandler(IUnitOfWork unitOfWork, IStorageService storageService, IHttpClientFactory httpClientFactoty, IAuthenticatedUserService authenticatedUserService)
        {
            _unitOfWork = unitOfWork;
            _storageService = storageService;
            _httpClientFactoty = httpClientFactoty;
            _authenticatedUserService = authenticatedUserService;
        }

        public async Task<CommandResponse<Domain.Entities.Playlist>> Handle(CreateCommand request, CancellationToken cancellationToken)
        {
            var playlist = new Domain.Entities.Playlist()
            {
                Name = request.Name,
                Description = request.Description,
                Thumbnail = await _storageService.SaveFile(request.Thumbnail, 0),
            };
            if (_authenticatedUserService.CheckRole("admin"))
                playlist.PlaylistType = PlaylistType.SYSTEM.ToString();
            else
                playlist.PlaylistType = PlaylistType.USER.ToString();
            var res = await _unitOfWork.PlaylistRepo.AddAsync(playlist);

            //var rs = await _httpClientFactoty.CreateClient().GetAsync("http://localhost:8089/predict/?"+playlist.FileMusic);
            //rs.EnsureSuccessStatusCode();
            //var resp = await rs.Content.ReadAsStringAsync();
            //var obj =  JsonConvert.DeserializeObject<Domain.Entities.Playlist>(resp);

            if (!_unitOfWork.Commit())
                return new CommandFail<Domain.Entities.Playlist>()
                {
                    Msg = "Create playlist Failed"
                };
            else
                return new CommandOK<Domain.Entities.Playlist>()
                {
                    ObjectId = res.Id,
                    Data = res,
                };
        }
    }

}
