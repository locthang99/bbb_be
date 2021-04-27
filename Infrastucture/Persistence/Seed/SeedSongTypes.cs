using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
namespace Persistence.Seed
{
    public static class SeedTypes
    {
        public static void SeedType(this ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Domain.Entities.Type>().HasData(
            //new Domain.Entities.Type
            //{
            //    Id = 1,
            //    Name = "Nhac tre"
            //},
            //new Domain.Entities.Type
            //{
            //    Id = 2,
            //    Name = "Nhac Remix"
            //},
            //new Domain.Entities.Type
            //{
            //    Id = 3,
            //    Name = "Nhac Pop"
            //},
            //new Domain.Entities.Type
            //{
            //    Id = 4,
            //    Name = "Nhac Ballad"
            //}
            //);
        }
    }
}
