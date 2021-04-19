using Application.Interfaces.RepoBase;
using Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Domain.Base;
using Application.Interfaces.Service;

namespace Persistence.Repositories.Base
{
    public class Repository<T> : IRepository<T> where T :AuditableBaseEntity
    {
        public readonly BigBlueBirdsDbContext _dbContext;
        public readonly IAuthenticatedUserService _authenticatedUserService;
        public Repository(BigBlueBirdsDbContext dbContext, IAuthenticatedUserService authenticatedUserService)
        {
            _dbContext = dbContext;
            _authenticatedUserService = authenticatedUserService;
        }
        public virtual async Task<T> GetByIdAsync(int id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }

        public async Task<IReadOnlyList<T>> GetPagedReponseAsync(int pageNumber, int pageSize)
        {
            return await _dbContext
                .Set<T>()
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<T> AddAsync(T entity)
        {
            await _dbContext.Set<T>().AddAsync(entity);
            entity.DateCreate = DateTime.Now;
            entity.CreatedBy = _authenticatedUserService.GetCurrentUserId();
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<int> UpdateAsync(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            entity.LastModified = DateTime.Now;
            entity.LastModifiedBy = _authenticatedUserService.GetCurrentUserId();
            _dbContext.Set<T>().Update(entity);
            return await _dbContext.SaveChangesAsync();
        }

        public async Task<int> DeleteAsync(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            return await _dbContext.SaveChangesAsync();
        }

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await _dbContext
                 .Set<T>()
                 .ToListAsync();
        }

        public bool CheckAuthorizeResource(T entiry)
        {
            if (_authenticatedUserService.GetCurrentUserId() == entiry.CreatedBy)
                return true;
            else
                return false;
        }
    }
}
