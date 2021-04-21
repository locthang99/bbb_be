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

namespace Application.Features.Song.Commands
{
    public class ReactionCommand : IRequest<Response<string>>
    {
        public int IdSong;
        public bool Like;
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
            var song = await _unitOfWork.SongRepo.GetByIdAsync(request.IdSong);
            if (song == null)
                throw new NotFoundException("Song not found");
            var userId = _authenticatedUserService.GetCurrentUserId();

            var song_like = await _unitOfWork.User_Like_SongRepo.GetByTwoIdAsync(userId, song.Id);

            if(song_like==null)
            {
                var totalLike = request.Like ? 1 : 0;
                var rs = request.Like ? song.TotalLike++:0;
                _unitOfWork.SongRepo.Update(song);
                var user_Like_Song = new User_Like_Song() { UserId = userId, SongId = song.Id ,TotalLike = totalLike};
                
                _unitOfWork.SongRepo.Update(song);
                await _unitOfWork.User_Like_SongRepo.AddAsync(user_Like_Song);
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
                if (!_unitOfWork.User_Like_SongRepo.CheckAuthorizeResource(song_like))
                    throw new UnauthorizeException();
                var rs = request.Like ? song.TotalLike++ : song.TotalLike -= song_like.TotalLike;
                var totalLike = request.Like ? song_like.TotalLike++ :  song_like.TotalLike = 0;
                _unitOfWork.SongRepo.Update(song);
                _unitOfWork.User_Like_SongRepo.Update(song_like);
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
