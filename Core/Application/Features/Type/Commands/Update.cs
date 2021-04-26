using Application.DTOs.Type;
using Application.DTOs.Type.TypeRequest;
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

namespace Application.Features.Type.Commands
{
    public class UpdateCommand : TypeUpdateRequest, IRequest<Response<Domain.Entities.Type>>
    {
        //[JsonIgnore]
        internal int Id { get; set; }
        public void SetId(int id)
        {
            Id = id;
        }
    }
    public class UpdateCommandHandler : IRequestHandler<UpdateCommand, Response<Domain.Entities.Type>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStorageService _storageService;
        public UpdateCommandHandler(IUnitOfWork unitOfWork, IStorageService storageService)
        {
            _unitOfWork = unitOfWork;
            _storageService = storageService;
        }

        public async Task<Response<Domain.Entities.Type>> Handle(UpdateCommand request, CancellationToken cancellationToken)
        {

            var Type = await _unitOfWork.TypeRepo.GetByIdAsync(request.Id);
            if (Type == null)
                throw new NotFoundException("Type not found");
            if (!_unitOfWork.TypeRepo.CheckAuthorizeResource(Type))
                throw new UnauthorizeException();
            if (request.Name != null)
                Type.Name = request.Name;
            if (request.Description != null)
                Type.Description = request.Description;
            if (request.Thumbnail != null)
                Type.Thumbnail = await _storageService.SaveFile(request.Thumbnail, 0);

            var res =  _unitOfWork.TypeRepo.Update(Type);

            if (!_unitOfWork.Commit())
                throw new UpdateRequestException("Update Type fail");
            else
                return new CommandOK<Domain.Entities.Type>()
                {
                    ObjectId = Type.Id,
                    Msg = "Update Type OK",
                };
        }
    }
}
