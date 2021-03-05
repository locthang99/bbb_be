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

namespace Persistence.Repositories.Base
{
    public class RealEntityRepository<T> : Repository<T>, IRealEntityRepository<T> where T : RealEntity
    {
        public readonly DbSet<T> _realEntity;

        public RealEntityRepository(BigBlueBirdsDbContext dbContext) : base(dbContext)
        {
            _realEntity = dbContext.Set<T>();
        }

        private IOrderedQueryable<T> Sort(PagedSortRequest rq, IQueryable<T> input)
        {
            if (rq.SortASC)
            {
                switch (rq.SortBy)
                {
                    case "Id":
                        return input.OrderBy(x => x.Id);
                    case "Name":
                        return input.OrderBy(x => x.Name);
                    case "DateCreate":
                        return input.OrderBy(x => x.DateCreate);
                    default:
                        return input.OrderBy(x => x.Id);
                }
            }
            else
            {
                switch (rq.SortBy)
                {
                    case "Id":
                        return input.OrderByDescending(x => x.Id);
                    case "Name":
                        return input.OrderByDescending(x => x.Name);
                    case "DateCreate":
                        return input.OrderByDescending(x => x.DateCreate);
                    default:
                        return input.OrderByDescending(x => x.Id);
                }
            }
        }

        public async Task<ResponseQuery<T>> GetAllPagedSortAsync(PagedSortRequest rq)
        {
            var data = _realEntity.Select(x => x).AsNoTracking();
            return new ResponseQuery<T>()
            {
                TotallRecord = data.Count(),
                Data = await Sort(rq, data).Skip((rq.Index - 1) * rq.PageSize).Take(rq.PageSize).ToListAsync()
            };
        }

        public async Task<ResponseQuery<T>> GetByNamePagedSortAsync(string name, PagedSortRequest rq)
        {
            var data = _realEntity.Where(r => r.Name.Contains(name) || name.Contains(r.Name)).AsNoTracking();
            return new ResponseQuery<T>()
            {
                TotallRecord = data.Count(),
                Data = await Sort(rq, data).Skip((rq.Index - 1) * rq.PageSize).Take(rq.PageSize).ToListAsync()
            };
        }

        public async Task<ResponseQuery<T>> GetByListIdPagedSortAsync(IReadOnlyList<int> listId, PagedSortRequest rq)
        {
            var data = _realEntity.Where(r => listId.Contains(r.Id)).AsNoTracking();
            return new ResponseQuery<T>()
            {
                TotallRecord = data.Count(),
                Data = await Sort(rq, data).Skip((rq.Index - 1) * rq.PageSize).Take(rq.PageSize).ToListAsync()
            };
        }
    }
}
