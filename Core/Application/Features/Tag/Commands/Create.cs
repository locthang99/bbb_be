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
using Application.DTOs.Tag.TagRequest;

namespace Application.Features.Tag.Commands
{
    public class CreateCommand : TagCreateRequest, IRequest<CommandResponse<Domain.Entities.Tag>>
    {

    }
    public class CreateCommandHandler : IRequestHandler<CreateCommand, CommandResponse<Domain.Entities.Tag>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStorageService _storageService;
        public readonly IAuthenticatedUserService _authenticatedUserService;
        public CreateCommandHandler(IUnitOfWork unitOfWork, IStorageService storageService, IAuthenticatedUserService authenticatedUserService)
        {
            _unitOfWork = unitOfWork;
            _storageService = storageService;
            _authenticatedUserService = authenticatedUserService;
        }

        public async Task<CommandResponse<Domain.Entities.Tag>> Handle(CreateCommand request, CancellationToken cancellationToken)
        {
            var tag = new Domain.Entities.Tag()
            {
                Name = request.Name,
                Description = request.Description,
                //Thumbnail = await _storageService.SaveFile(request.Thumbnail, 0),
            };
            //if (_authenticatedUserService.CheckRole("admin"))
            //    tag.TagType = TagType.SYSTEM.ToString();
            //else
            //    tag.TagType = TagType.USER.ToString();
            var res = await _unitOfWork.TagRepo.AddAsync(tag);

            if (!_unitOfWork.Commit())
                return new CommandFail<Domain.Entities.Tag>()
                {
                    Msg = "Create tag Failed"
                };
            else
                return new CommandOK<Domain.Entities.Tag>()
                {
                    ObjectId = res.Id,
                    Data = res,
                };
        }
    }

}
