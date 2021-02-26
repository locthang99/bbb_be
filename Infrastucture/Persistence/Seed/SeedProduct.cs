using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
namespace Persistence.Seed
{
    public static class SeedProduct
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product()
            {
                Id =1,
                Name = "aaaaa",
                Barcode = "vvvvvvvvvvv"
            },
            new Product()
            {
                Id = 2,
                Name = "aaaaa"
            }
            );

        }
    }
}
