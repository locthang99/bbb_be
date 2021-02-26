using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{   
    public class Song_SongTypeConfiguration : IEntityTypeConfiguration<Song_SongType>
    {
        public void Configure(EntityTypeBuilder<Song_SongType> builder)
        {
            builder.HasKey(t => new { t.SongId, t.SongTypeId });
            builder.ToTable("Song_SongTypes");
            builder.HasOne(s => s.Song).WithMany(pl => pl.Song_SongTypes)
                .HasForeignKey(pl => pl.SongId);
            builder.HasOne(pl => pl.SongType).WithMany(s => s.Song_SongTypes)
              .HasForeignKey(s => s.SongTypeId);
        }
    }
}
