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
using Application.DTOs.User.UserRequest;

namespace Application.Features.Song.Commands
{
    public class CommentCommand : UserCmtRequest,IRequest<Response<string>>
    {
    }
    public class CommentHandler : IRequestHandler<CommentCommand, Response<string>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public readonly IAuthenticatedUserService _authenticatedUserService;
        public CommentHandler(IUnitOfWork unitOfWork, IAuthenticatedUserService authenticatedUserService)
        {
            _unitOfWork = unitOfWork;
            _authenticatedUserService = authenticatedUserService;
        }
        public async Task<Response<string>> Handle(CommentCommand request, CancellationToken cancellationToken)
        {
            var song = await _unitOfWork.SongRepo.GetByIdAsync(request.ObjId);
            if (song == null)
                throw new NotFoundException("Song not found");
            var userId = _authenticatedUserService.GetCurrentUserId();

            song.TotalCmt++;
            _unitOfWork.SongRepo.Update(song);
            var user_Cmt_Song = new User_Cmt_Song() { UserId = userId, SongId = song.Id, Content = request.Content };

            _unitOfWork.SongRepo.Update(song);
            await _unitOfWork.User_Comment_SongRepo.AddAsync(user_Cmt_Song);
            if (_unitOfWork.Commit())
            {
                return new Response<string>()
                {
                    Msg = "Comment OK",
                    Data = request.Content
                };
            }

            throw new BadRequestException("Update Comment fail");
        }
    }
}
