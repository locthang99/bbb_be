using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.Configurations.BaseConfig;

namespace Persistence.Configurations
{
    public class Song_OwnerConfiguration : ExtensionEntityConfiguration<Song_Owner>, IEntityTypeConfiguration<Song_Owner>
    {
        public void Configure(EntityTypeBuilder<Song_Owner> builder)
        {
            ConfigureExtensionEntityBase(ref builder);
            builder.HasKey(t => new { t.SongId, t.OwnerId });
            builder.ToTable("Song_Owners");
            builder.HasOne(s => s.Song).WithMany(o => o.Song_Owners)
                .HasForeignKey(o => o.SongId);
            builder.HasOne(o => o.Owner).WithMany(s => s.Song_Owners)
              .HasForeignKey(s => s.OwnerId);
        }
    }
}
