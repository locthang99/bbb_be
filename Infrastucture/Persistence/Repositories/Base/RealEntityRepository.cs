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

namespace Persistence.Repositories.Base
{
    public class RealEntityRepository<T> : Repository<T>, IRealEntityRepository<T> where T : RealEntity
    {
        private readonly DbSet<T> _realEntity;

        public RealEntityRepository(BigBlueBirdsDbContext dbContext) : base(dbContext)
        {
            _realEntity = dbContext.Set<T>();
        }

        public async Task<IReadOnlyList<T>> GetAllPagedSortAsync(PagedSortRequest rq)
        {
            var data = _realEntity;
            if (rq.SortASC)
            {
                switch (rq.SortBy)
                {
                    case "Id":
                        data.OrderBy(x => x.Id);
                        break;
                    case "Name":
                        data.OrderBy(x => x.Name);
                        break;
                    case "DateCreate":
                        data.OrderBy(x => x.DateCreate);
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (rq.SortBy)
                {
                    case "Id":
                        data.OrderByDescending(x => x.Id);
                        break;
                    case "Name":
                        data.OrderByDescending(x => x.Name);
                        break;
                    case "DateCreate":
                        data.OrderByDescending(x => x.DateCreate);
                        break;
                    default:
                        break;
                }
            }
           return await data.Skip((rq.Index - 1) * rq.PageSize).Take(rq.PageSize).ToListAsync();
        }

        public async Task<IReadOnlyList<T>> GetByNameAsync(string name)
        {
            return await _realEntity.Where(r => r.Name.Contains(name)|| name.Contains(r.Name)).AsNoTracking().ToListAsync();
        }
    }
}
