using Application.DTOs.Song;
using Application.Interfaces.RepoBase;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces.Repo
{
    public interface ISongRepository : IRealEntityRepository<Song>
    {
        public SongDTO MapSong(Domain.Entities.Song song);
    }
}
