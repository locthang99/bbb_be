using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.Configurations.BaseConfig;

namespace Persistence.Configurations
{
    public class Song_SingerConfiguration : ExtensionEntityConfiguration<Song_Singer>, IEntityTypeConfiguration<Song_Singer>
    {
        public void Configure(EntityTypeBuilder<Song_Singer> builder)
        {
            ConfigureExtensionEntityBase(ref builder);
            builder.HasKey(t => new { t.SongId, t.SingerId });
            builder.ToTable("Song_Singers");
            builder.HasOne(s => s.Song).WithMany(o => o.Song_Singers)
                .HasForeignKey(o => o.SongId);
            builder.HasOne(o => o.Singer).WithMany(s => s.Song_Singers)
              .HasForeignKey(s => s.SingerId);
        }
    }
}
