using Application.Interfaces.RepoBase;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Domain.Base;
using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;
using System.Linq;

namespace Persistence.Repositories.Base
{
    public class RealEntityRepository<T> : Repository<T>, IRealEntityRepository<T> where T : RealEntity
    {
        private readonly DbSet<T> _realEntity;

        public RealEntityRepository(BigBlueBirdsDbContext dbContext) : base(dbContext)
        {
            _realEntity = dbContext.Set<T>();
        }

        public async Task<IReadOnlyList<T>> GetByNameAsync(string name)
        {
            return await _realEntity.Where(r => r.Name.Contains(name)|| name.Contains(r.Name)).AsNoTracking().ToListAsync();
        }
    }
}
