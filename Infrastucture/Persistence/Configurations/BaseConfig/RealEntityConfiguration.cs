using System;
using System.Collections.Generic;
using System.Text;
using Domain.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations.BaseConfig
{
    public class RealEntityConfiguration<T> : AuditableEntityConfiguration<T> where T : RealEntity
    {
        public EntityTypeBuilder<T> ConfigureRealEntityBase(ref EntityTypeBuilder<T> builder)
        {
            //builder.ToTable("AppConfigs");
            ConfigureBase(ref builder);
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Description).HasDefaultValue("");
            return builder;
        }
    }
}