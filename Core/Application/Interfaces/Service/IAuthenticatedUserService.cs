using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace Application.Interfaces.Service
{
    public interface IAuthenticatedUserService
    {
        int GetCurrentUserId();
        bool CheckAuthentication();
        bool CheckRole(string RoleName);
        ClaimsPrincipal GetClaimsPrincipalUser();
    }
}
