using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.RepoBase
{
    public interface IRepository<T>
    {
        Task<T> GetByIdAsync(int id);
        T GetById(int id);
        Task<IReadOnlyList<T>> GetAllAsync();
        Task<IReadOnlyList<T>> GetPagedReponseAsync(int pageNumber, int pageSize);
        IReadOnlyList<T> CustomFindBy(Expression<Func<T, bool>> predicate);
        Task<T> AddAsync(T entity);
        T Update(T entity);
        T Delete(T entity);
        T StrongDelete(T entity);
        T UnDelete(T entity);
        T Disable(T entity);
        bool CheckAuthorizeResource(T entiry);
    }
}
