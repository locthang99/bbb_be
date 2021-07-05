using Application.DTOs.User;
using Application.Exceptions;
using Application.Interfaces.Repo;
using Application.Interfaces.ResQuery;
using Application.Interfaces.Service;
using Application.Parameters;
using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using ThirdPartyServices.Storage;

namespace Persistence.Repositories.Repo
{
    public class AccountRepository : IAccountRepository
    {
        private readonly BigBlueBirdsDbContext _bigBlueBirdsDbContext;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly RoleManager<Role> _roleManager;
        private readonly IAuthenticatedUserService _authenticatedUserService;
        private readonly IConfiguration _config;
        private readonly IStorageService _storageService;
        public AccountRepository(
            BigBlueBirdsDbContext bigBlueBirdsDbContext,
            IAuthenticatedUserService authenticatedUserService,
            UserManager<User> userManager, SignInManager<User> signInManager,
            RoleManager<Role> roleManager, IConfiguration config, IStorageService storageService)
        {
            _bigBlueBirdsDbContext = bigBlueBirdsDbContext;
            _userManager = userManager;
            _authenticatedUserService = authenticatedUserService;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _config = config;
            _storageService = storageService;
        }

        public UserDTO MapUser(User user)
        {
            var data = new UserDTO()
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                PhoneNumber = user.PhoneNumber,
                UserName = user.UserName,
                Role = user.RoleBase,
                UserVip = user.UserVip,
                Dob = user.Dob,
                Email = user.Email,
                Thumbnail = user.Thumbnail

            };
            if (!user.Thumbnail.Contains("http") && user.Thumbnail != "")
                data.Thumbnail = _config["File:Image"] + user.Thumbnail;
            return data;
        }

        public IOrderedQueryable<User> Sort(PagedSortRequest rq, IQueryable<User> input)
        {
            var param = Expression.Parameter(typeof(User), "item");

            var sortExpression = Expression.Lambda<Func<User, object>>
                (Expression.Convert(Expression.Property(param, rq.SortBy), typeof(object)), param);
            if (rq.SortASC)
            {
                return input.OrderBy<User, object>(sortExpression);
            }
            else
            {
                return input.OrderByDescending<User, object>(sortExpression);
            }
        }

        public async Task<string> GenerateToken(User user)
        {
            var roles = await _userManager.GetRolesAsync(user);
            var claims = new[]
            {
                new Claim(ClaimTypes.Email,user.Email),
                new Claim(ClaimTypes.GivenName,user.Id.ToString()),
                new Claim(ClaimTypes.Role, string.Join(";",roles)),
                new Claim(ClaimTypes.Name,(user.FirstName+" "+user.LastName)),
                new Claim(ClaimTypes.NameIdentifier,user.Id.ToString())
            };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["JWTSettings:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(_config["JWTSettings:Issuer"],
                _config["JWTSettings:Issuer"],
                claims,
                expires: DateTime.Now.AddMinutes(Int32.Parse(_config["JWTSettings:DurationInMinutes"])),
                signingCredentials: creds);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
        public async Task<User> AddAsync(User entity,string pwd)
        {
            var rs = await _userManager.CreateAsync(entity, pwd);
            if (rs.Succeeded)
                return entity;
            else
                return null;
        }

        public User Delete(User entity)
        {
            entity.IsDelete = true;
            _bigBlueBirdsDbContext.Update(entity);
            return entity;
        }

        public User UnDelete(User entity)
        {
            entity.IsDelete = false;
            _bigBlueBirdsDbContext.Update(entity);
            return entity;
        }

        public async Task<User> StrongDeleteAsync(User entity)
        {
            var rs = await _userManager.DeleteAsync(entity);
            if (rs.Succeeded)
                return entity;
            return null;
        }

        public async Task<ResponseQuery<User>> GetAllPagedSortAsync(PagedSortRequest rq,string RoleBase,string name)
        {
            var listRole = RoleBase.Split(";");
            int Id;
            var isNumbericId = Int32.TryParse(name, out Id);
            if (string.IsNullOrWhiteSpace(name))
            {
                var data = _bigBlueBirdsDbContext.Users
                .Where(x => x.IsDelete == false && x.RoleBase.Contains(RoleBase));
                return new ResponseQuery<User>()
                {
                    TotallRecord = data.Count(),
                    Data = await Sort(rq, data).Skip(rq.Index * rq.PageSize).Take(rq.PageSize).ToListAsync()
                };
            }
            if (isNumbericId)
            {
                var data = _bigBlueBirdsDbContext.Users.Where(r =>
                r.Id == Id 
                || r.FirstName.ToUpper().Contains(name.ToUpper()) 
                || (name.ToUpper().Contains(r.FirstName.ToUpper())&& !string.IsNullOrEmpty(r.FirstName))
                || r.LastName.ToUpper().Contains(name.ToUpper())
                || name.ToUpper().Contains(r.LastName.ToUpper())
                || r.Email.ToUpper().Contains(name.ToUpper())
                || name.ToUpper().Contains(r.Email.ToUpper())
                )
                .Where(x => x.IsDelete == false && x.RoleBase.Contains(RoleBase));
                return new ResponseQuery<User>()
                {
                    TotallRecord = data.Count(),
                    Data = await Sort(rq, data).Skip(rq.Index * rq.PageSize).Take(rq.PageSize).ToListAsync()
                };
            }
            else
            {
                var data = _bigBlueBirdsDbContext.Users.Where(r =>
                r.FirstName.ToUpper().Contains(name.ToUpper())
                || (name.ToUpper().Contains(r.FirstName.ToUpper()) && !string.IsNullOrEmpty(r.FirstName))
                || r.LastName.ToUpper().Contains(name.ToUpper())
                || name.ToUpper().Contains(r.LastName.ToUpper())
                || r.Email.ToUpper().Contains(name.ToUpper())
                || name.ToUpper().Contains(r.Email.ToUpper())
                )
                .Where(x => x.IsDelete == false && x.RoleBase.Contains(RoleBase));
                return new ResponseQuery<User>()
                {
                    TotallRecord = data.Count(),
                    Data = await Sort(rq, data).Skip(rq.Index * rq.PageSize).Take(rq.PageSize).ToListAsync()
                };
            }
        }

        public async Task<User> GetByEmailAsync(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);
            return user;
        }

        public async Task<User> GetByIdAsync(int id)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());
            if (user == null)
                throw new NotFoundException("Not found user");
            return user;
        }

        public Task<ResponseQuery<User>> GetByListIdPagedSortAsync(IReadOnlyList<int> listId, PagedSortRequest rq)
        {
            throw new NotImplementedException();
        }

        public Task<User> SetRole(User entity)
        {
            throw new NotImplementedException();
        }

        public async Task<User> UpdateAsync(User entity)
        {
            var rs = _bigBlueBirdsDbContext.Users.Update(entity);
                return entity;
        }

        public async Task<ResponseQueryable<IQueryable<User>>> FindByAsync(Expression<Func<User, bool>> predicate, PagedSortRequest rq)
        {
            var data = _bigBlueBirdsDbContext.Users.Where(predicate).AsNoTracking();
            //listData.Add(Sort(rq, data).Skip((rq.Index - 1) * rq.PageSize).Take(rq.PageSize));
            return new ResponseQueryable<IQueryable<User>>()
            {
                TotallRecord = data.Count(),
                Data = Sort(rq, data).Skip(rq.Index * rq.PageSize).Take(rq.PageSize)
            };
        }

        public async Task<ResponseQuery<User>> GetListDeletedPagedSortAsync(PagedSortRequest rq, string name)
        {
            int Id;
            var isNumbericId = Int32.TryParse(name, out Id);
            if (string.IsNullOrWhiteSpace(name))
            {
                var data = _bigBlueBirdsDbContext.Users
                .Where(x => x.IsDelete == true);
                return new ResponseQuery<User>()
                {
                    TotallRecord = data.Count(),
                    Data = await Sort(rq, data).Skip(rq.Index * rq.PageSize).Take(rq.PageSize).ToListAsync()
                };
            }
            if (isNumbericId)
            {
                var data = _bigBlueBirdsDbContext.Users.Where(r =>
                r.Id == Id
                || r.FirstName.ToUpper().Contains(name.ToUpper())
                || (name.ToUpper().Contains(r.FirstName.ToUpper()) && !string.IsNullOrEmpty(r.FirstName))
                || r.LastName.ToUpper().Contains(name.ToUpper())
                || name.ToUpper().Contains(r.LastName.ToUpper())
                || r.Email.ToUpper().Contains(name.ToUpper())
                || name.ToUpper().Contains(r.Email.ToUpper())
                )
                .Where(x => x.IsDelete == true);
                return new ResponseQuery<User>()
                {
                    TotallRecord = data.Count(),
                    Data = await Sort(rq, data).Skip(rq.Index * rq.PageSize).Take(rq.PageSize).ToListAsync()
                };
            }
            else
            {
                var data = _bigBlueBirdsDbContext.Users.Where(r =>
                r.FirstName.ToUpper().Contains(name.ToUpper())
                || (name.ToUpper().Contains(r.FirstName.ToUpper()) && !string.IsNullOrEmpty(r.FirstName))
                || r.LastName.ToUpper().Contains(name.ToUpper())
                || name.ToUpper().Contains(r.LastName.ToUpper())
                || r.Email.ToUpper().Contains(name.ToUpper())
                || name.ToUpper().Contains(r.Email.ToUpper())
                )
                .Where(x => x.IsDelete == true);
                return new ResponseQuery<User>()
                {
                    TotallRecord = data.Count(),
                    Data = await Sort(rq, data).Skip(rq.Index * rq.PageSize).Take(rq.PageSize).ToListAsync()
                };
            }
        }
    }
}
