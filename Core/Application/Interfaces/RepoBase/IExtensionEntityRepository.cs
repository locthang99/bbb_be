using Application.Interfaces.ResQuery;
using Application.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.RepoBase
{
    public interface IExtensionEntityRepository<T> : IRepository<T>
    {
        Task<T> GetByTwoIdAsync(int id1,int id2);
        Task<ResponseQueryable<IQueryable<T>>> FindByAsync(Expression<Func<T, bool>> predicate, PagedSortRequest rq);
    }
}
