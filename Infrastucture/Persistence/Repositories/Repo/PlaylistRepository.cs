using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Persistence.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;
using Application.Interfaces.Repo;

namespace Persistence.Repositories.Repo
{
    public class PlaylistRepository : RealEntityRepository<Playlist>, IPlaylistRepository
    {
        private readonly DbSet<Playlist> _playlists;

        public PlaylistRepository(BigBlueBirdsDbContext dbContext) : base(dbContext)
        {
            _playlists = dbContext.Set<Playlist>();
        }

    }
}
