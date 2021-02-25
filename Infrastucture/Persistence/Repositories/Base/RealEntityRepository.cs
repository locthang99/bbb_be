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
    public class RealEntityRepository : Repository<RealEntity>, IRealEntityRepository<RealEntity>
    {
        private readonly DbSet<RealEntity> _realEntity;

        public RealEntityRepository(BigBlueBirdsDbContext dbContext) : base(dbContext)
        {
            _realEntity = dbContext.Set<RealEntity>();
        }

        public async Task<IReadOnlyList<RealEntity>> GetByNameAsync(string name)
        {
            return await _realEntity.Where(r => r.Name.Contains(name)|| name.Contains(r.Name)).AsNoTracking().ToListAsync();
        }
    }
}
