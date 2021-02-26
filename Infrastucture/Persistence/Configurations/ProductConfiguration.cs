using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class ProductConfiguration : AuditableEntityConfigurations<Product>, IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            ConfigureBase(ref builder);
            builder.ToTable("Products");
            builder.Property(x => x.Barcode).HasDefaultValue("1");

        }
    }
}
