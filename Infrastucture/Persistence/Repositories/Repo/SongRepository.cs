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
    public class SongRepository : RealEntityRepository<Song>,ISongRepository
    {
        private readonly DbSet<Song> _songs;

        public SongRepository(BigBlueBirdsDbContext dbContext) : base(dbContext)
        {
            _songs = dbContext.Set<Song>();
        }

    }
}
