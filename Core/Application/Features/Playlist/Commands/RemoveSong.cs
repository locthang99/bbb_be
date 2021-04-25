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
    public class RemoveSongCommand : IRequest<Response<string>>
    {
        public int IdPlaylist { get; set; }
        public int IdSong { get; set; }
        public void SetId(int idSong, int idPlaylist)
        {
            IdPlaylist = idPlaylist;
            IdSong = idSong;
        }

    }
    public class RemoveSongHandler : IRequestHandler<RemoveSongCommand, Response<string>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public readonly IAuthenticatedUserService _authenticatedUserService;
        public RemoveSongHandler(IUnitOfWork unitOfWork, IAuthenticatedUserService authenticatedUserService)
        {
            _unitOfWork = unitOfWork;
            _authenticatedUserService = authenticatedUserService;
        }
        public async Task<Response<string>> Handle(RemoveSongCommand request, CancellationToken cancellationToken)
        {
            var playlist = await _unitOfWork.PlaylistRepo.GetByIdAsync(request.IdPlaylist);
            if (playlist == null)
                throw new NotFoundException("Playlist not found");
            var song = await _unitOfWork.SongRepo.GetByIdAsync(request.IdSong);
            if (song == null)
                throw new NotFoundException("Song not found");


            var song_playlist = await _unitOfWork.Song_PlaylistRepo.GetByTwoIdAsync(song.Id, playlist.Id);

            if (song_playlist != null)
            {
                if (!_unitOfWork.Song_PlaylistRepo.CheckAuthorizeResource(song_playlist))
                    throw new UnauthorizeException();
                playlist.TotalSong--;
                _unitOfWork.PlaylistRepo.Update(playlist);
                //song_playlist = new Song_PlayList() { SongId = song.Id, PlayListId = playlist.Id };

                _unitOfWork.Song_PlaylistRepo.Delete(song_playlist);
                if (_unitOfWork.Commit())
                {
                    return new Response<string>()
                    {
                        Msg = "Remove song from playlist OK",
                        Data = null
                    };
                }
            }
            else
            {
                return new Response<string>()
                {
                    Msg = "Song not in this playlist",
                    Data = null
                };
            }
            throw new BadRequestException("Remove song fail");
        }
    }
}
