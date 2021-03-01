using Application.Parameters;
using Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.RepoBase
{
    public interface IRealEntityRepository<T> : IRepository<T> where T : RealEntity
    {
        Task<IReadOnlyList<T>> GetAllPagedSortAsync(PagedSortRequest rq);

        Task<IReadOnlyList<T>> GetByNameAsync(string name);
    }
}
