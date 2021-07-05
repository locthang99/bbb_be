using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.Configurations.BaseConfig;

namespace Persistence.Configurations
{
    public class InfoVipUserConfiguration : AuditableEntityConfiguration<InfoVipUser>, IEntityTypeConfiguration<InfoVipUser>
    {
        public void Configure(EntityTypeBuilder<InfoVipUser> builder)
        {
            ConfigureBase(ref builder);
            builder.ToTable("InfoVipUsers");
            builder.Property(x => x.UserId).IsRequired(true).HasDefaultValue(0);
            builder.Property(x => x.ExpireAt).IsRequired(true).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.Status).IsRequired(true).HasDefaultValue("NoVip");
        }

    }
}
