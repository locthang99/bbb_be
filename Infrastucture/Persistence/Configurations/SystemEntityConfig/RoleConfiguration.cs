using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.Configurations.BaseConfig;

namespace Persistence.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {           
            builder.ToTable("Roles");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.DateCreate).IsRequired(true).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.LastModified).IsRequired(true).HasDefaultValue(DateTime.Now);
        }
    }
}
