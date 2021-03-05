using Application.Interfaces.ResQuery;
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
        Task<ResponseQuery<T>> GetAllPagedSortAsync(PagedSortRequest rq);

        Task<ResponseQuery<T>> GetByNamePagedSortAsync(string name,PagedSortRequest rq);
        Task<ResponseQuery<T>> GetByListIdPagedSortAsync(IReadOnlyList<int> listId, PagedSortRequest rq);

    }
}
