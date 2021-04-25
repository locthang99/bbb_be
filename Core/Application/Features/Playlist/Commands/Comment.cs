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

namespace Application.Features.Playlist.Commands
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
            var playlist = await _unitOfWork.PlaylistRepo.GetByIdAsync(request.ObjId);
            if (playlist == null)
                throw new NotFoundException("Playlist not found");
            var userId = _authenticatedUserService.GetCurrentUserId();

            playlist.TotalCmt++;
            _unitOfWork.PlaylistRepo.Update(playlist);
            var user_Cmt_Playlist = new User_Cmt_Playlist() { UserId = userId, PlaylistId = playlist.Id, Content = request.Content };

            _unitOfWork.PlaylistRepo.Update(playlist);
            await _unitOfWork.User_Comment_PlaylistRepo.AddAsync(user_Cmt_Playlist);
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
