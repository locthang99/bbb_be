﻿using Application.Interfaces.RepoBase;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Domain.Base;
using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;
using System.Linq;
using Application.Interfaces.Service;

namespace Persistence.Repositories.Base
{
    public class ExtensionEntityRepository<T> : Repository<T>, IExtensionEntityRepository<T> where T : ExtensionEntity
    {
        public readonly DbSet<T> _extensionEntity;

        public ExtensionEntityRepository(BigBlueBirdsDbContext dbContext,IAuthenticatedUserService authenticatedUserService) : base(dbContext, authenticatedUserService)
        {
            _extensionEntity = dbContext.Set<T>();
        }

        public async Task<T> GetByTwoIdAsync(int id1, int id2)
        {
            return await _extensionEntity.FindAsync(id1, id2);
        }
    }
}