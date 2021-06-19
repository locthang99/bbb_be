using Application.DTOs.User;
using Application.Interfaces.ResQuery;
using Application.Parameters;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Repo
{
    public interface IAccountRepository
    {
        Task<User> GetByIdAsync(int id);
        Task<User> GetByEmailAsync(string email);
        Task<User> AddAsync(User entity,string pwd);
        Task<User> UpdateAsync(User entity);
        User Delete(User entity);
        User UnDelete(User entity);
        Task<User> StrongDeleteAsync(User entity);
        Task<User> SetRole(User entity);
        UserDTO MapUser(User entity);
        Task<string> GenerateToken(User entity);
        Task<ResponseQueryable<IQueryable<User>>> FindByAsync(Expression<Func<User, bool>> predicate, PagedSortRequest rq);
        Task<ResponseQuery<User>> GetAllPagedSortAsync(PagedSortRequest rq,string RoleBase,string Name);
        Task<ResponseQuery<User>> GetListDeletedPagedSortAsync(PagedSortRequest rq, string Name);
        Task<ResponseQuery<User>> GetByListIdPagedSortAsync(IReadOnlyList<int> listId, PagedSortRequest rq);
    }
}
