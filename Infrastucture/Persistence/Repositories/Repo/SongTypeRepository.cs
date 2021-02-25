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
    public class SongTypeRepository : RealEntityRepository<SongType>, ISongTypeRepository
    {
        private readonly DbSet<SongType> _songtypes;

        public SongTypeRepository(BigBlueBirdsDbContext dbContext) : base(dbContext)
        {
            _songtypes = dbContext.Set<SongType>();
        }

    }
}
