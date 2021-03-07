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

namespace Application.Features.Song.Commands
{
    public class CreateCommand : SongCreateRequest, IRequest<CommandResponse<RealEntity>>
    {

    }
    public class CreateCommandHandler : IRequestHandler<CreateCommand, CommandResponse<RealEntity>>
    {
        private readonly ISongRepository _songRepository;
        private readonly IStorageService _storageService;
        public CreateCommandHandler(ISongRepository songRepository, IStorageService storageService)
        {
            _songRepository = songRepository;
            _storageService = storageService;
        }

        public async Task<CommandResponse<RealEntity>> Handle(CreateCommand request, CancellationToken cancellationToken)
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
            if (res == null)
                return new CommandFail<RealEntity>()
                {
                    Msg = "Create song Failed"
                };
            else
                return new CommandOK<RealEntity>()
                {
                    ObjectId = res.Id,
                    Msg = "Create song OK",                  
                };
        }
    }
}
