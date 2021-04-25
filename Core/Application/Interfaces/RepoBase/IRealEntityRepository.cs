using Application.Interfaces.ResQuery;
using Application.Parameters;
using Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.RepoBase
{
    public interface IRealEntityRepository<T> : IRepository<T> where T : RealEntity
    {
        Task<ResponseQuery<T>> GetAllPagedSortAsync(PagedSortRequest rq);

        Task<ResponseQuery<T>> GetByNamePagedSortAsync(string name,PagedSortRequest rq);
        Task<ResponseQuery<T>> GetByListIdPagedSortAsync(IReadOnlyList<int> listId, PagedSortRequest rq);
        Task<ResponseQueryable<IQueryable<T>>> FindByAsync(Expression<Func<T, bool>> predicate, PagedSortRequest rq);


    }
}
