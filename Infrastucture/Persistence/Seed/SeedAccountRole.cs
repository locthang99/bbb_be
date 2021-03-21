using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence.Seed
{
    public static class SeedAccountRole
    {
        public static void SeedAccount_Role(this ModelBuilder modelBuilder)
        {
            int supperAdminId = 1;
            int adminId = 2;
            int userId = 3;
            int singerId = 4;
            int authorId = 5;

            int roleSupperAdminId = 1;
            int roleAdminId = 2;
            int roleUserId = 3;
            int roleSingerId = 4;
            int roleAuthorId = 5;

            modelBuilder.Entity<IdentityUserRole<int>>().HasData(
            new IdentityUserRole<int>
            {
                RoleId = roleSupperAdminId,
                UserId = supperAdminId
            },
            new IdentityUserRole<int>
            {
                RoleId = roleAdminId,
                UserId = adminId
            },
            new IdentityUserRole<int>
            {
                RoleId = roleUserId,
                UserId = userId
            },
            new IdentityUserRole<int>
            {
                RoleId = roleSingerId,
                UserId = singerId
            },
            new IdentityUserRole<int>
            {
                RoleId = roleAuthorId,
                UserId = authorId
            }
            );
        }
    }
}
