using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence.Seed
{
    public static class SeedOrder
    {
        public static void SeedOrders(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().HasData(new Order()
            {
                Id = 1,
                UserId = 3,
                ItemId = 1,
                Amount = 3000000,
                Status = "Success",
                DiscountAdded = 30,
                Name = "d249d798-e542-4eb3-bba9-978c4c3efb86",
                Description = "",
                
            }
            );
        }
    }

}
