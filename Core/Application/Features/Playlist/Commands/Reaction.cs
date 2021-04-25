using Application.Exceptions;
using Application.Interfaces.Service;
using Application.Interfaces.UoW;
using Application.Wrappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Domain.Entities;

namespace Application.Features.Playlist.Commands
{
    public class ReactionCommand : IRequest<Response<string>>
    {
        public int IdPlaylist { get; set; }
        public bool Like { get; set; }
    }
    public class ReactionHandler : IRequestHandler<ReactionCommand, Response<string>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public readonly IAuthenticatedUserService _authenticatedUserService;
        public ReactionHandler(IUnitOfWork unitOfWork,IAuthenticatedUserService authenticatedUserService)
        {
            _unitOfWork = unitOfWork;
            _authenticatedUserService = authenticatedUserService;
        }
        public async Task<Response<string>> Handle(ReactionCommand request, CancellationToken cancellationToken)
        {
            var playlist = await _unitOfWork.PlaylistRepo.GetByIdAsync(request.IdPlaylist);
            if (playlist == null)
                throw new NotFoundException("Playlist not found");
            var userId = _authenticatedUserService.GetCurrentUserId();

            var playlist_like = await _unitOfWork.User_Like_PlaylistRepo.GetByTwoIdAsync(userId, playlist.Id);

            if(playlist_like==null)
            {
                var totalLike = request.Like ? 1 : 0;
                var rs = request.Like ? playlist.TotalLike++:0;
                _unitOfWork.PlaylistRepo.Update(playlist);
                var user_Like_Playlist = new User_Like_Playlist() { UserId = userId, PlaylistId = playlist.Id ,TotalLike = totalLike};
                
                _unitOfWork.PlaylistRepo.Update(playlist);
                await _unitOfWork.User_Like_PlaylistRepo.AddAsync(user_Like_Playlist);
                if(_unitOfWork.Commit())
                {
                    var msg = request.Like ? "Like OK" : "Unlike OK";
                    return new Response<string>()
                    {
                        Msg = msg,
                        Data = null
                    };
                }
            }
            else
            {
                if (!_unitOfWork.User_Like_PlaylistRepo.CheckAuthorizeResource(playlist_like))
                    throw new UnauthorizeException();
                var rs = request.Like ? playlist.TotalLike++ : playlist.TotalLike -= playlist_like.TotalLike;
                var totalLike = request.Like ? playlist_like.TotalLike++ :  playlist_like.TotalLike = 0;
                _unitOfWork.PlaylistRepo.Update(playlist);
                _unitOfWork.User_Like_PlaylistRepo.Update(playlist_like);
                if (_unitOfWork.Commit())
                {
                    var msg = request.Like ? "Like OK" : "Unlike OK";
                    return new Response<string>()
                    {
                        Msg = msg,
                        Data = null
                    };
                }
            }
            throw new BadRequestException("Update reaction fail");
        }
    }
}
