using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.Configurations.BaseConfig;

namespace Persistence.Configurations
{
    public class Song_TagConfiguration : ExtensionEntityConfiguration<Song_Tag>, IEntityTypeConfiguration<Song_Tag>
    {
        public void Configure(EntityTypeBuilder<Song_Tag> builder)
        {
            ConfigureExtensionEntityBase(ref builder);
            //builder.HasKey(t => new { t.SongId, t.TagId });
            builder.ToTable("Song_Tags");
            builder.HasOne(s => s.Song).WithMany(pl => pl.Song_Tags)
                .HasForeignKey(pl => pl.SongId);
            builder.HasOne(pl => pl.Tag).WithMany(s => s.Song_Tags)
              .HasForeignKey(s => s.TagId);
        }
    }
}
