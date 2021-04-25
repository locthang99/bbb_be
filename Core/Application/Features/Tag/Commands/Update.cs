using Application.DTOs.PlayList;
using Application.DTOs.PlayList.PlayListRequest;
using Application.DTOs.Tag.TagRequest;
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

namespace Application.Features.Tag.Commands
{
    public class UpdateCommand : TagUpdateRequest, IRequest<Response<Domain.Entities.Tag>>
    {
        //[JsonIgnore]
        internal int Id { get; set; }
        public void SetId(int id)
        {
            Id = id;
        }
    }
    public class UpdateCommandHandler : IRequestHandler<UpdateCommand, Response<Domain.Entities.Tag>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStorageService _storageService;
        public UpdateCommandHandler(IUnitOfWork unitOfWork, IStorageService storageService)
        {
            _unitOfWork = unitOfWork;
            _storageService = storageService;
        }

        public async Task<Response<Domain.Entities.Tag>> Handle(UpdateCommand request, CancellationToken cancellationToken)
        {

            var tag = await _unitOfWork.TagRepo.GetByIdAsync(request.Id);
            if (tag == null)
                throw new NotFoundException("Tag not found");
            if (!_unitOfWork.TagRepo.CheckAuthorizeResource(tag))
                throw new UnauthorizeException();
            if (request.Name != null)
                tag.Name = request.Name;
            if (request.Description != null)
                tag.Description = request.Description;

            var res =  _unitOfWork.TagRepo.Update(tag);

            if (!_unitOfWork.Commit())
                throw new UpdateRequestException("Update tag fail");
            else
                return new CommandOK<Domain.Entities.Tag>()
                {
                    ObjectId = tag.Id,
                    Msg = "Update tag OK",
                };
        }
    }
}
