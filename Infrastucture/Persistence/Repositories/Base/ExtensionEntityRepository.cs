using Application.Interfaces.RepoBase;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Domain.Base;
using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;
using System.Linq;
using Application.Interfaces.Service;
using System.Linq.Expressions;
using Application.Interfaces.ResQuery;
using Application.Parameters;

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

        //public IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate)
        //{
        //    IEnumerable<T> query = _extensionEntity.Where(predicate).AsEnumerable();
        //    return query;
        //}
        public async Task<ResponseQueryable<IQueryable<T>>> FindByAsync(Expression<Func<T, bool>> predicate, PagedSortRequest rq)
        {
            var data = _extensionEntity.Where(predicate).AsNoTracking();
            List<IQueryable<T>> listData = new List<IQueryable<T>>();
            //listData.Add(Sort(rq, data).Skip((rq.Index - 1) * rq.PageSize).Take(rq.PageSize));
            return new ResponseQueryable<IQueryable<T>>()
            {
                TotallRecord = data.Count(),
                Data = Sort(rq, data).Skip(rq.Index * rq.PageSize).Take(rq.PageSize)
            };
        }
    }
}