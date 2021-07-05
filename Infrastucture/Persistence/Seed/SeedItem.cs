using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
namespace Persistence.Seed
{
    public static class SeedItem
    {
        public static void SeedItems(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>().HasData(new Item()
            {
                Id = 1,
                Name = "Gói vip Ruby",
                Description = "Nghe ngất ngây",
                AddTime = 3000,
                Price = 3000000,
                Discount = 30,
                Thumbnail = "https://cdn3.vectorstock.com/i/1000x1000/70/52/red-vip-symbol-vector-14707052.jpg",
                TypeUpdate = "UpdateVip"
            },
            new Item()
            {
                Id = 2,
                Name = "Gói vip Vàng",
                Description = "Nghe ngây ngất",
                AddTime = 2000,
                Price = 2000000,
                Discount = 20,
                Thumbnail = "https://cdn3.vectorstock.com/i/1000x1000/88/52/gold-vip-symbol-set-1-vector-14028852.jpg",
                TypeUpdate = "UpdateVip"
            },
            new Item()
            {
                Id = 3,
                Name = "Gói vip Bạc",
                Description = "Nghe say đắm",
                AddTime = 1000,
                Price = 1000000,
                Discount = 10,
                Thumbnail = "https://cdn1.vectorstock.com/i/1000x1000/78/80/silver-vip-symbol-set-2-vector-14037880.jpg",
                TypeUpdate = "UpdateVip"
            },
            new Item()
            {
                Id = 4,
                Name = "Gói vip Đồng",
                Description = "Nghe đắm say",
                AddTime = 500,
                Price = 500000,
                Discount = 5,
                Thumbnail = "https://cdn5.vectorstock.com/i/1000x1000/78/79/bronze-vip-symbol-set-3-vector-14037879.jpg",
                TypeUpdate = "UpdateVip"
            }
            );

        }
    }
}
