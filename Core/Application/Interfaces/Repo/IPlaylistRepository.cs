using Application.DTOs.PlayList;
using Application.Interfaces.RepoBase;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces.Repo
{
    public interface IPlaylistRepository : IRealEntityRepository<Playlist>
    {
        public PlaylistDTO MapPlaylist(Domain.Entities.Playlist pl);
    }
}
