using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class PlayListConfiguration : IEntityTypeConfiguration<Playlist>
    {
        public void Configure(EntityTypeBuilder<Playlist> builder)
        {
            builder.ToTable("PlayList");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Thumbnail).IsRequired().HasDefaultValue("");
            builder.Property(x => x.DateCreate).IsRequired().HasDefaultValue(DateTime.Now);
            builder.Property(x => x.Description).IsRequired();
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
