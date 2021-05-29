using Application.Interfaces.RepoBase;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Domain.Base;
using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;
using System.Linq;
using Application.Parameters;
using Application.Interfaces.ResQuery;
using Application.Interfaces.Service;
using System.Linq.Expressions;
using System.Reflection;

namespace Persistence.Repositories.Base
{
    public class RealEntityRepository<T> : Repository<T>, IRealEntityRepository<T> where T : RealEntity
    {
        public readonly DbSet<T> _realEntity;

        public RealEntityRepository(BigBlueBirdsDbContext dbContext, IAuthenticatedUserService authenticatedUserService) : base(dbContext, authenticatedUserService)
        {
            _realEntity = dbContext.Set<T>();
        }

        public async Task<ResponseQuery<T>> GetAllPagedSortAsync(PagedSortRequest rq)
        {
            var data = _realEntity.Select(x => x).Where(x => x.IsDelete == false);
            return new ResponseQuery<T>()
            {
                TotallRecord = data.Count(),
                Data = await Sort(rq, data).Skip(rq.Index * rq.PageSize).Take(rq.PageSize).ToListAsync()
            };
        }

        public async Task<ResponseQuery<T>> GetByNamePagedSortAsync(string name, PagedSortRequest rq)
        {
            int Id;
            var isNumbericId = Int32.TryParse(name, out Id);
            if (string.IsNullOrWhiteSpace(name))
            {
                return await GetAllPagedSortAsync(rq);
            }
            if(isNumbericId)
            {
                var data = _realEntity.Where(r => r.Id==Id || r.Name.ToUpper().Contains(name.ToUpper()) || name.ToUpper().Contains(r.Name.ToUpper())).Where(x => x.IsDelete == false);
                return new ResponseQuery<T>()
                {
                    TotallRecord = data.Count(),
                    Data = await Sort(rq, data).Skip(rq.Index * rq.PageSize).Take(rq.PageSize).ToListAsync()
                };
            }
            else
            {
                var data = _realEntity.Where(r => r.Name.ToUpper().Contains(name.ToUpper()) || name.ToUpper().Contains(r.Name.ToUpper())).Where(x => x.IsDelete == false);
                return new ResponseQuery<T>()
                {
                    TotallRecord = data.Count(),
                    Data = await Sort(rq, data).Skip(rq.Index * rq.PageSize).Take(rq.PageSize).ToListAsync()
                };
            }
        }

        public async Task<ResponseQuery<T>> GetByListIdPagedSortAsync(IReadOnlyList<int> listId)
        {
            var data = _realEntity.Where(r => listId.Contains(r.Id)).Where(x => x.IsDelete == false);
            return new ResponseQuery<T>()
            {
                TotallRecord = data.Count(),
                Data = await data.ToListAsync()
            };
        }

        public async Task<ResponseQueryable<IQueryable<T>>> FindByAsync(Expression<Func<T, bool>> predicate, PagedSortRequest rq)
        {
            var data = _realEntity.Where(predicate).Where(x => x.IsDelete == false);
            //listData.Add(Sort(rq, data).Skip((rq.Index - 1) * rq.PageSize).Take(rq.PageSize));
            return new ResponseQueryable<IQueryable<T>>()
            {
                TotallRecord = data.Count(),
                Data = Sort(rq, data).Skip(rq.Index * rq.PageSize).Take(rq.PageSize)
            };
        }

        public async Task<ResponseQuery<T>> GetByListDeletedSortAsync(PagedSortRequest rq)
        {
            var data = _realEntity.Where(x => x.IsDelete == true);
            //listData.Add(Sort(rq, data).Skip((rq.Index - 1) * rq.PageSize).Take(rq.PageSize));
            return new ResponseQuery<T>()
            {
                TotallRecord = data.Count(),
                Data = await Sort(rq, data).Skip(rq.Index * rq.PageSize).Take(rq.PageSize).ToListAsync()
            };
        }
    }
}
