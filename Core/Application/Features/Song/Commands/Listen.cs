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
    public class ListenCommand : IRequest<Response<Object>>
    {
        public int SongId { get; set; }
    }
    public class ListenHandler : IRequestHandler<ListenCommand, Response<Object>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public readonly IAuthenticatedUserService _authenticatedUserService;
        public ListenHandler(IUnitOfWork unitOfWork, IAuthenticatedUserService authenticatedUserService)
        {
            _unitOfWork = unitOfWork;
            _authenticatedUserService = authenticatedUserService;
        }
        public async Task<Response<Object>> Handle(ListenCommand request, CancellationToken cancellationToken)
        {
            var song = await _unitOfWork.SongRepo.GetByIdAsync(request.SongId);
            if (song == null)
                throw new NotFoundException("Song not found");
            var userId = _authenticatedUserService.GetCurrentUserId();
            await _unitOfWork.HistoryRepo.AddAsync(new History()
            {
                ActionType = Enum.ActionType.LISTEN.ToString(),
                ObjectType = Enum.ObjectType.SONG.ToString(),
                ObjectId = song.Id.ToString(),
                UserId = userId
            });
            song.TotalListen++;
            _unitOfWork.SongRepo.Update(song);
            if (_unitOfWork.Commit())
                return new Response<object>()
                {
                    Msg = "Listen OK",
                    Data = null
                };
            
            throw new BadRequestException("Update Listen fail");
        }
    }
}
