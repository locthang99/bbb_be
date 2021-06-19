using Application.Exceptions;
using Application.Interfaces.Repo;
using Application.Interfaces.UoW;
using Application.Wrappers;
using MediatR;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using ThirdPartyServices.Storage;

namespace Application.Features.Account.Admin.Commands
{
    public class DeleteCommand : IRequest<Response<Domain.Entities.User>>
    {
        [JsonIgnore]
        internal int Id { get; set; }
        public void SetId(int id)
        {
            Id = id;
        }
    }
    public class DeleteCommandHandler : IRequestHandler<DeleteCommand, Response<Domain.Entities.User>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStorageService _storageService;
        public DeleteCommandHandler(IUnitOfWork unitOfWork, IStorageService storageService)
        {
            _unitOfWork = unitOfWork;
            _storageService = storageService;
        }

        public async Task<Response<Domain.Entities.User>> Handle(DeleteCommand request, CancellationToken cancellationToken)
        {

            var account = await _unitOfWork.AccountRepo.GetByIdAsync(request.Id);
            if (account == null)
                throw new NotFoundException("account not found");
            var res = _unitOfWork.AccountRepo.Delete(account);

            if (!_unitOfWork.Commit())
                throw new DeleteRequestException("Delete fail");
            else
            {
                return new CommandOK<Domain.Entities.User>()
                {
                    ObjectId = account.Id,
                    Msg = "Delete account OK",
                };
            }
        }
    }
}
