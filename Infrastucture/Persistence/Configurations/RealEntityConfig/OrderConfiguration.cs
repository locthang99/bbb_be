using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.Configurations.BaseConfig;

namespace Persistence.Configurations
{
    public class OrderConfiguration : RealEntityConfiguration<Order>, IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            ConfigureRealEntityBase(ref builder);
            builder.ToTable("Orders");
            builder.Property(x => x.Amount).IsRequired().HasDefaultValue(0);
            builder.Property(x => x.DiscountAdded).IsRequired().HasDefaultValue(0);
            builder.Property(x => x.Status).IsRequired().HasDefaultValue("Pending");
            builder.Property(x => x.UserId).IsRequired().HasDefaultValue(0);
            builder.Property(x => x.ItemId).IsRequired().HasDefaultValue(0);
            //builder.HasOne(x => x.FileMusic).WithOne(s => s.Order).HasForeignKey<FileMusic>(x => x.IdOrder);

        }
    }
}
