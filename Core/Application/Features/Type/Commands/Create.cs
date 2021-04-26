using Application.DTOs.Type;
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
using Application.DTOs.Type.TypeRequest;
using Application.Interfaces.Service;
using Application.Enum;

namespace Application.Features.Type.Commands
{
    public class CreateCommand : TypeCreateRequest, IRequest<CommandResponse<Domain.Entities.Type>>
    {

    }
    public class CreateCommandHandler : IRequestHandler<CreateCommand, CommandResponse<Domain.Entities.Type>>
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

        public async Task<CommandResponse<Domain.Entities.Type>> Handle(CreateCommand request, CancellationToken cancellationToken)
        {
            var Type = new Domain.Entities.Type()
            {
                Name = request.Name,
                Description = request.Description,
                Thumbnail = await _storageService.SaveFile(request.Thumbnail, 0),
            };

            var res = await _unitOfWork.TypeRepo.AddAsync(Type);

            if (!_unitOfWork.Commit())
                return new CommandFail<Domain.Entities.Type>()
                {
                    Msg = "Create Type Failed"
                };
            else
                return new CommandOK<Domain.Entities.Type>()
                {
                    ObjectId = res.Id,
                    Data = res,
                };
        }
    }

}
