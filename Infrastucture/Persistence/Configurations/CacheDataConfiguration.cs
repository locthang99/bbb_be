using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class CacheDataConfiguration : IEntityTypeConfiguration<CacheData>
    {
        public void Configure(EntityTypeBuilder<CacheData> builder)
        {
            builder.ToTable("CacheDatas");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.OwnerId).IsRequired();
            builder.Property(x => x.Data).IsRequired();
            builder.Property(x => x.Type).IsRequired();
            builder.Property(x => x.TimeExpire).IsRequired().HasDefaultValue(1);
            builder.Property(x => x.DateCreate).IsRequired().HasDefaultValue(DateTime.Now);
        }
    }
}
