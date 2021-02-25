using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.RepoBase
{
    public interface IExtensionEntityRepository<T> : IRepository<T>
    {
        Task<T> GetByTwoIdAsync(int id1,int id2);
    }
}
