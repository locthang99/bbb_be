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

namespace Application.Features.Playlist.Commands
{
    public class UpdateCommand : PlayListUpdateRequest, IRequest<Response<Domain.Entities.Playlist>>
    {
        //[JsonIgnore]
        internal int Id { get; set; }
        public void SetId(int id)
        {
            Id = id;
        }
    }
    public class UpdateCommandHandler : IRequestHandler<UpdateCommand, Response<Domain.Entities.Playlist>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStorageService _storageService;
        public UpdateCommandHandler(IUnitOfWork unitOfWork, IStorageService storageService)
        {
            _unitOfWork = unitOfWork;
            _storageService = storageService;
        }

        public async Task<Response<Domain.Entities.Playlist>> Handle(UpdateCommand request, CancellationToken cancellationToken)
        {

            var playlist = await _unitOfWork.PlaylistRepo.GetByIdAsync(request.Id);
            if (playlist == null)
                throw new NotFoundException("Playlist not found");
            if (!_unitOfWork.PlaylistRepo.CheckAuthorizeResource(playlist))
                throw new UnauthorizeException();
            if (request.Name != null)
                playlist.Name = request.Name;
            if (request.Description != null)
                playlist.Description = request.Description;
            if (request.Thumbnail != null)
                playlist.Thumbnail = await _storageService.SaveFile(request.Thumbnail, 0);

            var res =  _unitOfWork.PlaylistRepo.Update(playlist);

            if (!_unitOfWork.Commit())
                throw new UpdateRequestException("Update playlist fail");
            else
                return new CommandOK<Domain.Entities.Playlist>()
                {
                    ObjectId = playlist.Id,
                    Msg = "Update playlist OK",
                };
        }
    }
}
