using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Persistence.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;
using Application.Interfaces.Repo;
using Application.Interfaces.Service;

namespace Persistence.Repositories.Repo
{
    public class TypeRepository : RealEntityRepository<Domain.Entities.Type>, ITypeRepository
    {
        private readonly DbSet<Domain.Entities.Type> _types;

        public TypeRepository(BigBlueBirdsDbContext dbContext, IAuthenticatedUserService authenticatedUserService) : base(dbContext, authenticatedUserService)
        {
            _types = dbContext.Set<Domain.Entities.Type>();
        }

    }
}
