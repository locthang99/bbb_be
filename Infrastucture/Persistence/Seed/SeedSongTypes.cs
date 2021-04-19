using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence.Seed
{
    public static class SeedSongTypes
    {
        public static void SeedSongType(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SongType>().HasData(
            new SongType
            {
                Id = 1,
                Name = "Nhac tre"
            },
            new SongType
            {
                Id = 2,
                Name = "Nhac Remix"
            },
            new SongType
            {
                Id = 3,
                Name = "Nhac Pop"
            },
            new SongType
            {
                Id = 4,
                Name = "Nhac Ballad"
            }
            );
        }
    }
}
