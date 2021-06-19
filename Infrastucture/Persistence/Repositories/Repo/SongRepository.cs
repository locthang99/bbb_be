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
using Application.DTOs.Type;
using Application.DTOs.Owner;
using Application.DTOs.Tag;
using Microsoft.Extensions.Configuration;
using Application.Interfaces.Service;
using ThirdPartyServices.StringService;

namespace Persistence.Repositories.Repo
{
    public class SongRepository : RealEntityRepository<Song>,ISongRepository
    {
        private readonly IConfiguration _config;

        private readonly DbSet<Song> _songs;

        public SongRepository(BigBlueBirdsDbContext dbContext, IAuthenticatedUserService authenticatedUserService, IStringService strSv, IConfiguration config) : base(dbContext, authenticatedUserService, strSv)
        {
            _songs = dbContext.Set<Song>();
            _config = config;
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
                SongVip = song.SongVip,
                Country = song.Country,
                IsChecked = song.IsChecked,
                IsOfficial = song.IsOfficial,
                Lyric = song.Lyric,
                Duration = song.Duration,
                Types = _dbContext.Song_Types.Where(z => z.SongId == song.Id).Select(c => new TypeValueDTO {
                    Id = c.TypeId,
                    Name = c.Type.Name,
                    Value = c.Value
                }).ToList(),
                Tags = _dbContext.Song_Tags.Where(z => z.SongId == song.Id).Select(c => new TagDTO()
                {
                    Id = c.TagId,
                    Name = c.Tag.Name
                }).ToList(),
                Owners = _dbContext.Users.Where(z => z.Id==song.CreatedBy).Select(c => new OwnerDTO()
                {
                    OwnerId = c.Id,
                    NameOwner = c.FirstName + " " + c.LastName,
                    Thumbnail = c.Thumbnail
                }).ToList(),
                Singers = _dbContext.Song_Singers.Where(z => z.SongId == song.Id).Select(c => new SingerDTO()
                {
                    SingerId = c.SingerId,
                    NameSinger = c.Singer.FirstName + " " + c.Singer.LastName,
                    Thumbnail = c.Singer.Thumbnail
                }).ToList(),
                Composers = _dbContext.Song_Composers.Where(z => z.SongId == song.Id).Select(c => new ComposerDTO()
                {
                    ComposerId = c.ComposerId,
                    NameComposer = c.Composer.FirstName + " " + c.Composer.LastName,
                    Thumbnail = c.Composer.Thumbnail
                }).ToList(),
            };
            if (!string.IsNullOrEmpty(song.Lyric) && !song.Lyric.Contains("http"))
                data.Lyric = _config["File:Lyric"] + song.Lyric;
            else
                data.Lyric = song.Lyric;

            if (!song.Thumbnail.Contains("http") && song.Thumbnail != "")
                data.Thumbnail = _config["File:Image"] + song.Thumbnail;
            else
                data.Thumbnail = song.Thumbnail;

            if (!song.FileMusic128.Contains("http") && song.FileMusic128 != "")
                data.FileMusic128 = _config["File:Music"] + song.FileMusic128;
            else
                data.FileMusic128 = song.FileMusic128;

            if (!song.FileMusic320.Contains("http") && song.FileMusic320 != "")
                data.FileMusic320 = _config["File:Music"] + song.FileMusic320;
            else
                data.FileMusic320 = song.FileMusic320;

            if (!song.FileMusicLossless.Contains("http") && song.FileMusicLossless != "")
                data.FileMusicLossless = _config["File:Music"] + song.FileMusicLossless;
            else
                data.FileMusicLossless = song.FileMusicLossless;

            return data;

        }
    }
}
