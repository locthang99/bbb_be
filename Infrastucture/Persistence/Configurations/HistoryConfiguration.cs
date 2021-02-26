using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class HistoryConfiguration : IEntityTypeConfiguration<History>
    {
        public void Configure(EntityTypeBuilder<History> builder)
        {
            builder.ToTable("Histories");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.DateTime).IsRequired();
            builder.Property(x => x.ActionType).IsRequired();
            builder.Property(x => x.ObjectType).IsRequired();
            builder.Property(x => x.ObjectId);
            builder.Property(x => x.ObjectName);
        }
    }
}
