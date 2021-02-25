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
    public class TagRepository : RealEntityRepository<Tag>, ITagRepository
    {
        private readonly DbSet<Tag> _tags;

        public TagRepository(BigBlueBirdsDbContext dbContext) : base(dbContext)
        {
            _tags = dbContext.Set<Tag>();
        }

    }
}
