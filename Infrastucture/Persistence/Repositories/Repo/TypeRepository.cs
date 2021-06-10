using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Persistence.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;
using Application.Interfaces.Repo;
using Application.Interfaces.Service;
using Application.DTOs.Type;
using Microsoft.Extensions.Configuration;
using System.Linq;
using Application.DTOs.Owner;

namespace Persistence.Repositories.Repo
{
    public class TypeRepository : RealEntityRepository<Domain.Entities.Type>, ITypeRepository
    {
        private readonly IConfiguration _config;

        private readonly DbSet<Tag> _tags;

        public TypeRepository(BigBlueBirdsDbContext dbContext, IAuthenticatedUserService authenticatedUserService, IConfiguration config) : base(dbContext, authenticatedUserService)
        {
            _tags = dbContext.Set<Tag>();
            _config = config;
        }

        public TypeDTO MapType(Domain.Entities.Type type)
        {
            if (type == null)
                return null;
            var data = new TypeDTO()
            {
                Id = type.Id,
                Name = type.Name,
                Description = type.Description,
                DateCreate = type.DateCreate,
                Owner = _dbContext.Users.Where(z => z.Id == type.CreatedBy).Select(c => new OwnerDTO()
                {
                    OwnerId = c.Id,
                    NameOwner = c.FirstName + " " + c.LastName,
                    Thumbnail = c.Thumbnail
                }).ToList().FirstOrDefault(),
            };
            if (!type.Thumbnail.Contains("http") && type.Thumbnail != "")
                data.Thumbnail = _config["File:Image"] + type.Thumbnail;
            else
                data.Thumbnail = type.Thumbnail;
            return data;
        }
    }
}
