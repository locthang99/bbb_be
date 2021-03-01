using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Persistence.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;
using Application.Interfaces.Repo;
using Application.DTOs.Song;
using System.Linq;
using Application.DTOs.SongType;
using Application.DTOs.Owner;
using Application.DTOs.Tag;

namespace Persistence.Repositories.Repo
{
    public class SongRepository : RealEntityRepository<Song>,ISongRepository
    {
        private readonly DbSet<Song> _songs;

        public SongRepository(BigBlueBirdsDbContext dbContext) : base(dbContext)
        {
            _songs = dbContext.Set<Song>();
        }

        public SongDTO MapSong(Song song)
        {
            if (song == null)
                return null;
            var data = new SongDTO()
            {
                Id = song.Id,
                Name = song.Name,
                Description = song.Description,
                DateCreate = song.DateCreate,
                TotalListen = song.TotalListen,
                TotalLike = song.TotalLike,
                TotalCmt = song.TotalCmt,
                TotalDownload = song.TotalDownload,
                Lyric = song.Lyric,
                Duration = song.Duration,
                Types = _dbContext.Song_SongTypes.Where(z => z.SongId == song.Id).Select(c => new SongTypeDTO() { Id = c.SongTypeId, Name = c.SongType.Name }).ToList(),
                Owners = _dbContext.Song_Owers.Where(z => z.SongId == song.Id).Select(c => new OwnerDTO()
                {
                    OwnerId = c.OwnerId,
                    NameOwner = c.Owner.FirstName + " " + c.Owner.LastName,
                    Thumbnail = c.Owner.Thumbnail
                }).ToList(),
                Tags = _dbContext.Song_Tags.Where(z => z.SongId == song.Id).Select(c => new TagDTO()
                {
                    Id = c.TagId,
                    Name = c.Tag.Name
                }).ToList()
            };
            //if (!song.Thumbnail.Contains("http") && song.Thumbnail != "")
            //    data.Thumbnail = _config["File:Image"] + song.Thumbnail;
            //else
            //    data.Thumbnail = song.Thumbnail;
            //if (!song.FileMusic.Contains("http") && song.FileMusic != "")
            //    data.FileMusic = _config["File:Music"] + song.FileMusic;
            //else
            //    data.FileMusic = song.FileMusic;
            return data;

        }
    }
}
