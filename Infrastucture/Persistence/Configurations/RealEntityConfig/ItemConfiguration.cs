using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.Configurations.BaseConfig;

namespace Persistence.Configurations
{
    public class ItemConfiguration : RealEntityConfiguration<Item>, IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            ConfigureRealEntityBase(ref builder);
            builder.ToTable("Items");
            builder.Property(x => x.Price).IsRequired().HasDefaultValue(0);
            builder.Property(x => x.Discount).IsRequired().HasDefaultValue(0);
            builder.Property(x => x.Thumbnail).IsRequired().HasDefaultValue("");
            builder.Property(x => x.AddTime).IsRequired().HasDefaultValue(0);
            builder.Property(x => x.TypeUpdate).IsRequired().HasDefaultValue("UpdateVip");
        }
    }
}
