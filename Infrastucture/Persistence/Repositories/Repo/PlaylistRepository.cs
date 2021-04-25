using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Persistence.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;
using Application.Interfaces.Repo;
using Application.Interfaces.Service;
using Application.DTOs.PlayList;
using System.Linq;
using Application.DTOs.Type;
using Application.DTOs.Tag;
using Application.DTOs.Owner;
using Microsoft.Extensions.Configuration;

namespace Persistence.Repositories.Repo
{
    public class PlaylistRepository : RealEntityRepository<Playlist>, IPlaylistRepository
    {
        private readonly IConfiguration _config;
        private readonly DbSet<Playlist> _playlists;

        public PlaylistRepository(BigBlueBirdsDbContext dbContext, IAuthenticatedUserService authenticatedUserService, IConfiguration config) : base(dbContext, authenticatedUserService)
        {
            _playlists = dbContext.Set<Playlist>();
            _config = config;
        }

        public PlaylistDTO MapPlaylist(Playlist playlist)
        {
            if (playlist == null)
                return null;
            var data = new PlaylistDTO()
            {
                Id = playlist.Id,
                Name = playlist.Name,
                Description = playlist.Description,
                DateCreate = playlist.DateCreate,
                TotalListen = playlist.TotalListen,
                TotalLike = playlist.TotalLike,
                TotalCmt = playlist.TotalCmt,
                TotalSong = playlist.TotalSong,
                //Types = _dbContext.Song_Types.Where(z => z.SongId == playlist.Id).Select(c => new TypeDTO()
                //{
                //    Id = c.TypeId,
                //    Name = c.Type.Name
                //}).ToList(),
                //Tags = _dbContext.Song_Tags.Where(z => z.SongId == playlist.Id).Select(c => new TagDTO()
                //{
                //    Id = c.TagId,
                //    Name = c.Tag.Name
                //}).ToList(),
                Owner = _dbContext.Users.Where(z => z.Id == playlist.CreatedBy).Select(c => new OwnerDTO()
                {
                    OwnerId = c.Id,
                    NameOwner = c.FirstName + " " + c.LastName,
                    Thumbnail = c.Thumbnail
                }).ToList().First(),
            };

            if (!playlist.Thumbnail.Contains("http") && playlist.Thumbnail != "")
                data.Thumbnail = _config["File:Image"] + playlist.Thumbnail;
            else
                data.Thumbnail = playlist.Thumbnail;
            return data;
        }
    }
}
