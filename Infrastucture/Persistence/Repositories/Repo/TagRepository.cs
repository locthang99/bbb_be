using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Persistence.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;
using Application.Interfaces.Repo;
using Application.Interfaces.Service;
using Application.DTOs.Tag;
using Microsoft.Extensions.Configuration;
using System.Linq;
using Application.DTOs.Owner;

namespace Persistence.Repositories.Repo
{
    public class TagRepository : RealEntityRepository<Tag>, ITagRepository
    {
        private readonly IConfiguration _config;

        private readonly DbSet<Tag> _tags;

        public TagRepository(BigBlueBirdsDbContext dbContext, IAuthenticatedUserService authenticatedUserService, IConfiguration config) : base(dbContext, authenticatedUserService)
        {
            _tags = dbContext.Set<Tag>();
            _config = config;
        }

        public TagDTO MapTag(Tag tag)
        {
            if (tag == null)
                return null;
            var data = new TagDTO()
            {
                Id = tag.Id,
                Name = tag.Name,
                Description = tag.Description,
                DateCreate = tag.DateCreate,
                Owner = _dbContext.Users.Where(z => z.Id == tag.CreatedBy).Select(c => new OwnerDTO()
                {
                    OwnerId = c.Id,
                    NameOwner = c.FirstName + " " + c.LastName,
                    Thumbnail = c.Thumbnail
                }).ToList().FirstOrDefault(),
            };
            return data;
        }
    }
}
