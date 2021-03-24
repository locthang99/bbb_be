using Application.DTOs.User;
using Application.Exceptions;
using Application.Interfaces.Repo;
using Application.Interfaces.ResQuery;
using Application.Interfaces.Service;
using Application.Parameters;
using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ThirdPartyServices.Storage;

namespace Persistence.Repositories.Repo
{
    public class AccountRepository : IAccountRepository<User>
    {
        private readonly BigBlueBirdsDbContext bigBlueBirdsDbContext;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly RoleManager<Role> _roleManager;
        private readonly IAuthenticatedUserService _authenticatedUserService;
        private readonly IConfiguration _config;
        private readonly IStorageService _storageService;
        public AccountRepository(IAuthenticatedUserService authenticatedUserService,
            UserManager<User> userManager, SignInManager<User> signInManager,
            RoleManager<Role> roleManager, IConfiguration config, IStorageService storageService)
        {
            _userManager = userManager;
            _authenticatedUserService = authenticatedUserService;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _config = config;
            _storageService = storageService;
        }

        public async Task<UserDTO> MapUserAsync(User user)
        {
            var data = new UserDTO()
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                PhoneNumber = user.PhoneNumber,
                UserName = user.UserName,
                Dob = user.Dob,
                Role = string.Join(";", await _userManager.GetRolesAsync(user)),
                Email = user.Email,
                Thumbnail = user.Thumbnail

            };

            if (!user.Thumbnail.Contains("http") && user.Thumbnail != "")
                data.Thumbnail = _config["File:Image"] + user.Thumbnail;
            return data;
        }
        public async Task<User> AddAsync(User entity,string pwd)
        {
            var rs = await _userManager.CreateAsync(entity, pwd);
            if (rs.Succeeded)
                return entity;
            else
                return null;
        }

        public async Task<User> DeleteAsync(User entity)
        {
            var rs = await _userManager.DeleteAsync(entity);
            if (rs.Succeeded)
                return entity;
            else
                return null;
        }

        public Task<ResponseQuery<User>> GetAllPagedSortAsync(PagedSortRequest rq)
        {
            throw new NotImplementedException();
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

        public Task<User> UpdateAsync(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
