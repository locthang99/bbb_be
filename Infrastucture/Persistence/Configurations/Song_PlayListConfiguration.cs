using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class Song_PlayListConfiguration : IEntityTypeConfiguration<Song_PlayList>
    {
        public void Configure(EntityTypeBuilder<Song_PlayList> builder)
        {
            builder.HasKey(t => new { t.SongId, t.PlayListId });
            builder.ToTable("Song_PlayLists");
            builder.HasOne(s => s.Song).WithMany(pl => pl.Song_PlayLists)
                .HasForeignKey(pl => pl.SongId);
            builder.HasOne(pl => pl.PlayList).WithMany(s => s.Song_PlayLists)
              .HasForeignKey(s => s.PlayListId);
        }
    }
}
