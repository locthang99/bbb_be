using Application.Exceptions;
using Application.Interfaces.Service;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BackendAPI.Services
{
    public class AuthenticatedUserService : IAuthenticatedUserService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public AuthenticatedUserService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public int GetCurrentUserId()
        {
            if (!CheckAuthentication())
                throw new AuthFailedException("Not login");
            if (_httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier) != null)
                return Int32.Parse( _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);
            else
                throw new AuthFailedException("Not login");
        }
        public bool CheckAuthentication()
        {
            if (_httpContextAccessor.HttpContext.User.Identity.IsAuthenticated)
                return true;
            else
                return false;
        }

        public bool CheckRole(string RoleName)
        {
            if (_httpContextAccessor.HttpContext.User.IsInRole(RoleName))
                return true;
            else
                return false;
        }

        public ClaimsPrincipal GetClaimsPrincipalUser()
        {
            return _httpContextAccessor.HttpContext.User;
        }
    }
}
