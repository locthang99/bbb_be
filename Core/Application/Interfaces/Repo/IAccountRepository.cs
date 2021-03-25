using Application.DTOs.User;
using Application.Interfaces.ResQuery;
using Application.Parameters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Repo
{
    public interface IAccountRepository<T>
    {
        Task<T> GetByIdAsync(int id);
        Task<T> GetByEmailAsync(string email);
        Task<T> AddAsync(T entity,string pwd);
        Task<T> UpdateAsync(T entity);
        Task<T> DeleteAsync(T entity);
        Task<T> SetRole(T entity);
        Task<UserDTO> MapUserAsync(T entity);
        Task<string> GenerateToken(T entity);
        Task<ResponseQuery<T>> GetAllPagedSortAsync(PagedSortRequest rq);
        Task<ResponseQuery<T>> GetByListIdPagedSortAsync(IReadOnlyList<int> listId, PagedSortRequest rq);
    }
}
