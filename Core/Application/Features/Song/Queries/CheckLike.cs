using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.DTOs.Song;
using Application.Exceptions;
using Application.Interfaces.Repo;
using Application.Interfaces.Service;
using Application.Interfaces.UoW;
using Application.Parameters;
using Application.Wrappers;
using MediatR;

namespace Application.Features.Song.Queries
{
    public class CheckLikeQuery : IRequest<Response<Object>>
    {
        public int SongId { get; set; }
    }
    public class CheckLikeHandler : IRequestHandler<CheckLikeQuery, Response<Object>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public readonly IAuthenticatedUserService _authenticatedUserService;

        public CheckLikeHandler(IUnitOfWork songRepository, IAuthenticatedUserService authenticatedUserService)
        {
            _unitOfWork = songRepository;
            _authenticatedUserService = authenticatedUserService;
        }
        public async Task<Response<Object>> Handle(CheckLikeQuery request, CancellationToken cancellationToken)
        {
            var userId = _authenticatedUserService.GetCurrentUserId();
            var song = await _unitOfWork.SongRepo.GetByIdAsync(request.SongId);
            if(song==null)
                throw new NotFoundException("Song not found");
            var res = await _unitOfWork.User_Like_SongRepo.GetByTwoIdAsync(userId, request.SongId);
            //return new NotFoundReponse<SongDTO>();

            //var data = _unitOfWork.MapSong(res);
            if(res==null || res.TotalLike <= 0)
                return new Response<Object>()
                {
                    Msg="Not like",
                    Data = new { TotalLike = 0 }
                };
            else
                return new Response<Object>()
                {
                    Msg = "Not like",
                    Data = new { TotalLike = res.TotalLike }
                };
        }


    }
}
