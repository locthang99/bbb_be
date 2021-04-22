using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.Configurations.BaseConfig;

namespace Persistence.Configurations
{
    public class Song_ComposerConfiguration : ExtensionEntityConfiguration<Song_Composer>, IEntityTypeConfiguration<Song_Composer>
    {
        public void Configure(EntityTypeBuilder<Song_Composer> builder)
        {
            ConfigureExtensionEntityBase(ref builder);
            builder.HasKey(t => new { t.SongId, t.ComposerId }); 
            builder.ToTable("Song_Composers");
            builder.HasOne(s => s.Song).WithMany(o => o.Song_Composers)
                .HasForeignKey(o => o.SongId);
            builder.HasOne(o => o.Composer).WithMany(s => s.Song_Composers)
              .HasForeignKey(s => s.ComposerId);
        }
    }
}
