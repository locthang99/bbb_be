using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.RepoBase
{
    public interface IRealEntityRepository<T> : IRepository<T>
    {
        Task<IReadOnlyList<T>> GetByNameAsync(string name);
    }
}
