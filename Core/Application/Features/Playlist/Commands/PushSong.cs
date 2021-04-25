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
    public class PushSongCommand : IRequest<Response<string>>
    {
        public int IdPlaylist { get; set;}
        public int IdSong { get; set;}
        public void SetId(int idSong,int idPlaylist)
        {
            IdPlaylist = idPlaylist;
            IdSong = idSong;
        }
    }
    public class PushSongHandler : IRequestHandler<PushSongCommand, Response<string>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public readonly IAuthenticatedUserService _authenticatedUserService;
        public PushSongHandler(IUnitOfWork unitOfWork, IAuthenticatedUserService authenticatedUserService)
        {
            _unitOfWork = unitOfWork;
            _authenticatedUserService = authenticatedUserService;
        }
        public async Task<Response<string>> Handle(PushSongCommand request, CancellationToken cancellationToken)
        {
            var playlist = await _unitOfWork.PlaylistRepo.GetByIdAsync(request.IdPlaylist);
            if (playlist == null)
                throw new NotFoundException("Playlist not found");
            var song = await _unitOfWork.SongRepo.GetByIdAsync(request.IdSong);
            if (song == null)
                throw new NotFoundException("Song not found");

            var song_playlist = await _unitOfWork.Song_PlaylistRepo.GetByTwoIdAsync(song.Id, playlist.Id);

            if (song_playlist == null)
            {
                playlist.TotalSong++;
                _unitOfWork.PlaylistRepo.Update(playlist);
                song_playlist = new Song_PlayList() { SongId = song.Id, PlayListId = playlist.Id };

                _unitOfWork.PlaylistRepo.Update(playlist);
                await _unitOfWork.Song_PlaylistRepo.AddAsync(song_playlist);
                if (_unitOfWork.Commit())
                {

                    return new Response<string>()
                    {
                        Msg = "Pusdongto playlist OK",
                        Data = null
                    };
                }
            }
            else
            {
                return new Response<string>()
                {
                    Msg = "Song have been added to this playlist",
                    Data = null
                };
            }
            throw new BadRequestException("Push song fail");
        }
    }
}
