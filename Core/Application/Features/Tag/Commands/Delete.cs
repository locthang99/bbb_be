using Application.DTOs.PlayList;
using Application.DTOs.PlayList.PlayListRequest;
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
    public class DeleteCommand : IRequest<Response<Domain.Entities.Tag>>
    {
        [JsonIgnore]
        internal int Id { get; set; }
        public void SetId(int id)
        {
            Id = id;
        }
    }
    public class DeleteCommandHandler : IRequestHandler<DeleteCommand, Response<Domain.Entities.Tag>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStorageService _storageService;
        public DeleteCommandHandler(IUnitOfWork unitOfWork, IStorageService storageService)
        {
            _unitOfWork = unitOfWork;
            _storageService = storageService;
        }

        public async Task<Response<Domain.Entities.Tag>> Handle(DeleteCommand request, CancellationToken cancellationToken)
        {

            var playlist = await _unitOfWork.TagRepo.GetByIdAsync(request.Id);
            if (playlist == null)
                throw new NotFoundException("Tag not found");
            if (!_unitOfWork.TagRepo.CheckAuthorizeResource(playlist))
                throw new UnauthorizeException();
            var res =  _unitOfWork.TagRepo.Delete(playlist);

            if (!_unitOfWork.Commit())
                throw new DeleteRequestException("Delete fail");
            else
            {
                return new CommandOK<Domain.Entities.Tag>()
                {
                    ObjectId = playlist.Id,
                    Msg = "Delete playlist OK",
                };
            }
        }
    }
}
