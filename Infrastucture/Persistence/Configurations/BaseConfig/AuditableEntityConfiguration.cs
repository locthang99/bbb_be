using System;
using System.Collections.Generic;
using System.Text;
using Domain.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations.BaseConfig
{
    public class AuditableEntityConfiguration<T> where T: AuditableBaseEntity
    {
        public EntityTypeBuilder<T> ConfigureBase(ref EntityTypeBuilder<T> builder)
        {
            //builder.ToTable("AppConfigs");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.DateCreate).IsRequired(true).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.LastModified).IsRequired(true).HasDefaultValue(DateTime.Now);
            return builder;
        }
    }
}