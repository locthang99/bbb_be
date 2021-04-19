using System;
using System.Collections.Generic;
using System.Text;
using Domain.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations.BaseConfig
{
    public class ExtensionEntityConfiguration<T>: AuditableEntityConfiguration<T> where T : ExtensionEntity
    {
        public EntityTypeBuilder<T> ConfigureExtensionEntityBase(ref EntityTypeBuilder<T> builder)
        {
            //builder.ToTable("AppConfigs");
            //ConfigureBase(ref builder);
            builder.Property(x => x.DateCreate).IsRequired(true).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.LastModified).IsRequired(true).HasDefaultValue(DateTime.Now);
            return builder;
        }
    }
}