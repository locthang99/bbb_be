using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence.Seed
{
    public static class SeedRoles
    {
        public static void SeedRole(this ModelBuilder modelBuilder)
        {
            int roleSupperAdminId = 1;
            int roleAdminId = 2;
            int roleUserId = 3;
            int roleSingerId = 4;
            int roleAuthorId = 5;
            modelBuilder.Entity<Role>().HasData(
            new Role
            {
                Id = roleSupperAdminId,
                Name = "SUPPERADMIN",
                NormalizedName = "SUPPERADMIN",
            },
            new Role
            {
                Id = roleAdminId,
                Name = "ADMIN",
                NormalizedName = "ADMIN",
            },
            new Role
            {
                Id = roleUserId,
                Name = "USER",
                NormalizedName = "USER",
            },
            new Role
            {
                Id = roleSingerId,
                Name = "SINGER",
                NormalizedName = "SINGER",
            },
            new Role
            {
                Id = roleAuthorId,
                Name = "AUTHOR",
                NormalizedName = "AUTHOR",
            }
            );
        }

    }
}
