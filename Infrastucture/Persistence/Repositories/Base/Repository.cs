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
using Application.Parameters;
using System.Linq.Expressions;

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

        public IOrderedQueryable<T> Sort(PagedSortRequest rq, IQueryable<T> input)
        {
            var param = Expression.Parameter(typeof(T), "item");

            var sortExpression = Expression.Lambda<Func<T, object>>
                (Expression.Convert(Expression.Property(param, rq.SortBy), typeof(object)), param);
            if (rq.SortASC)
            {
                return input.OrderBy<T, object>(sortExpression);
            }
            else
            {
                return input.OrderByDescending<T, object>(sortExpression);
            }
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
            try
            {
                entity.CreatedBy = _authenticatedUserService.GetCurrentUserId();
            }
            catch
            {
                entity.CreatedBy = 0;
            }
            //await _dbContext.SaveChangesAsync();
            return entity;
        }

        public T Update(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            entity.LastModified = DateTime.Now;
            try
            {
                entity.CreatedBy = _authenticatedUserService.GetCurrentUserId();
            }
            catch
            {
                entity.CreatedBy = 0;
            }
            _dbContext.Set<T>().Update(entity);
            return entity;
            //return await _dbContext.SaveChangesAsync();
        }

        public T Delete(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            return entity;
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
