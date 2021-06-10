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
    public class StrongDeleteCommand : IRequest<Response<Domain.Entities.Type>>
    {
        [JsonIgnore]
        internal int Id { get; set; }
        public void SetId(int id)
        {
            Id = id;
        }
    }
    public class StrongDeleteCommandHandler : IRequestHandler<StrongDeleteCommand, Response<Domain.Entities.Type>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStorageService _storageService;
        public StrongDeleteCommandHandler(IUnitOfWork unitOfWork, IStorageService storageService)
        {
            _unitOfWork = unitOfWork;
            _storageService = storageService;
        }

        public async Task<Response<Domain.Entities.Type>> Handle(StrongDeleteCommand request, CancellationToken cancellationToken)
        {

            var Type = await _unitOfWork.TypeRepo.GetByIdAsync(request.Id);
            if (Type == null)
                throw new NotFoundException("Type not found");
            if (!_unitOfWork.TypeRepo.CheckAuthorizeResource(Type))
                throw new UnauthorizeException();
            var res = _unitOfWork.TypeRepo.StrongDelete(Type);

            if (!_unitOfWork.Commit())
                throw new DeleteRequestException("StrongDelete fail");
            else
            {
                //await _storageService.DeleteFileAsync(Type.Thumbnail, 0);
                return new CommandOK<Domain.Entities.Type>()
                {
                    ObjectId = Type.Id,
                    Msg = "StrongDelete Type OK",
                };
            }
        }
    }
}
