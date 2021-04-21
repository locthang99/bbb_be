using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.Configurations.BaseConfig;

namespace Persistence.Configurations
{   
    public class Song_TypeConfiguration : ExtensionEntityConfiguration<Song_Type>,IEntityTypeConfiguration<Song_Type>
    {
        public void Configure(EntityTypeBuilder<Song_Type> builder)
        {
            ConfigureExtensionEntityBase(ref builder);
            builder.HasKey(t => new { t.SongId, t.TypeId });
            builder.ToTable("Song_Types");
            builder.HasOne(s => s.Song).WithMany(pl => pl.Song_Types)
                .HasForeignKey(pl => pl.SongId);
            builder.HasOne(pl => pl.Type).WithMany(s => s.Song_Types)
              .HasForeignKey(s => s.TypeId);
        }
    }
}
