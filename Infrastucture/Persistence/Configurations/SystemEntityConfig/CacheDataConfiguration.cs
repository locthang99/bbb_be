using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.Configurations.BaseConfig;

namespace Persistence.Configurations
{
    public class CacheDataConfiguration : AuditableEntityConfiguration<CacheData>, IEntityTypeConfiguration<CacheData>
    {
        public void Configure(EntityTypeBuilder<CacheData> builder)
        {
            ConfigureBase(ref builder);
            builder.ToTable("CacheDatas");
            builder.Property(x => x.OwnerId).IsRequired();
            builder.Property(x => x.Data).IsRequired();
            builder.Property(x => x.Type).IsRequired();
            builder.Property(x => x.TimeExpire).IsRequired().HasDefaultValue(1);
        }
    }
}
