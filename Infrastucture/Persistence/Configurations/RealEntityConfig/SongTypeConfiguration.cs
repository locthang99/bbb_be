using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.Configurations.BaseConfig;

namespace Persistence.Configurations
{
    public class SongTypeConfiguration : RealEntityConfiguration<SongType>, IEntityTypeConfiguration<SongType>
    {
        public void Configure(EntityTypeBuilder<SongType> builder)
        {
            ConfigureRealEntityBase(ref builder);
            builder.ToTable("SongTypes");
        }
    }
}
