using Application.Enum;
using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence.Seed
{
    public static class SeedAccounts
    {
        public static void SeedAccount(this ModelBuilder modelBuilder)
        {
            int supperAdminId = 1;
            int adminId = 2;
            int userId = 3;
            int singerId = 4;
            int authorId = 5;
            var hasher = new PasswordHasher<User>();
            modelBuilder.Entity<User>().HasData(
            new User
            {
                Id = supperAdminId,
                UserName = "supperadmin",
                NormalizedUserName = "supperadmin".ToUpper(),
                Email = "supperadmin@gmail.com",
                NormalizedEmail = "supperadmin@gmail.com".ToUpper(),
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Abcd1234$"),
                SecurityStamp = string.Empty,
                FirstName = "Supper Admin",
                LastName = "BigBluebirds",
                AccountType = AccountType.SYSTEM.ToString()
            },
            new User
            {
                Id = adminId,
                UserName = "admin",
                NormalizedUserName = "admin".ToUpper(),
                Email = "admin@gmail.com",
                NormalizedEmail = "admin@gmail.com".ToUpper(),
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Abcd1234$"),
                SecurityStamp = string.Empty,
                FirstName = "Admin",
                LastName = "BigBluebirds",
                AccountType = AccountType.SYSTEM.ToString()
            },
            new User
            {
                Id = userId,
                UserName = "user",
                NormalizedUserName = "user".ToUpper(),
                Email = "user@gmail.com",
                NormalizedEmail = "user@gmail.com".ToUpper(),
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Abcd1234$"),
                SecurityStamp = string.Empty,
                FirstName = "User",
                LastName = "User",
                AccountType = AccountType.SYSTEM.ToString()
            },
             new User
             {
                 Id = singerId,
                 UserName = "singer",
                 NormalizedUserName = "singer".ToUpper(),
                 Email = "singer@gmail.com",
                 NormalizedEmail = "singer@gmail.com".ToUpper(),
                 EmailConfirmed = true,
                 PasswordHash = hasher.HashPassword(null, "Abcd1234$"),
                 SecurityStamp = string.Empty,
                 FirstName = "Singer",
                 LastName = "Singer",
                 AccountType = AccountType.SYSTEM.ToString()
             },
             new User
             {
                 Id = authorId,
                 UserName = "author",
                 NormalizedUserName = "author".ToUpper(),
                 Email = "author@gmail.com",
                 NormalizedEmail = "author@gmail.com".ToUpper(),
                 EmailConfirmed = true,
                 PasswordHash = hasher.HashPassword(null, "Abcd1234$"),
                 SecurityStamp = string.Empty,
                 FirstName = "Author",
                 LastName = "Author",
                 AccountType = AccountType.SYSTEM.ToString()
             }

            );
        }
    }
}
