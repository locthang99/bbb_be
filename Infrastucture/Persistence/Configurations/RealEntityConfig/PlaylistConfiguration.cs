using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.Configurations.BaseConfig;

namespace Persistence.Configurations
{
    public class PlaylistConfiguration : RealEntityConfiguration<Playlist>, IEntityTypeConfiguration<Playlist>
    {
        public void Configure(EntityTypeBuilder<Playlist> builder)
        {
            ConfigureRealEntityBase(ref builder);
            builder.ToTable("Playlists");
            builder.Property(x => x.Thumbnail).IsRequired().HasDefaultValue("");
            builder.Property(x => x.TotalLike).IsRequired().HasDefaultValue(0);
            builder.Property(x => x.TotalCmt).IsRequired().HasDefaultValue(0);
            builder.Property(x => x.TotalListen).IsRequired().HasDefaultValue(0);
            builder.Property(x => x.TotalSong).IsRequired().HasDefaultValue(0);
            builder.Property(x => x.PlaylistType).IsRequired();
            //builder.HasMany(x=>x.FileImages).WithOne(x=>x.PlayList).HasForeignKey(x=>x.IdPlayList).OnDelete(DeleteBehavior.Cascade);
            builder.Property(x => x.OwnerId).IsRequired();
            //builder.HasOne(x => x.Owner).WithMany(x => x.PlaylistPrivate).HasForeignKey(x => x.OwnerId);
        }
    }
}
