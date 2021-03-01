using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.Configurations.BaseConfig;

namespace Persistence.Configurations
{
    public class HistoryConfiguration : AuditableEntityConfiguration<History>,IEntityTypeConfiguration<History>
    {
        public void Configure(EntityTypeBuilder<History> builder)
        {
            ConfigureBase(ref builder);
            builder.ToTable("Histories");
            builder.Property(x => x.DateTime).IsRequired();
            builder.Property(x => x.ActionType).IsRequired();
            builder.Property(x => x.ObjectType).IsRequired();
            builder.Property(x => x.ObjectId);
            builder.Property(x => x.ObjectName);
        }
    }
}
