using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.Configurations.BaseConfig;

namespace Persistence.Configurations
{
    public class SongConfiguration : RealEntityConfiguration<Song>, IEntityTypeConfiguration<Song>
    {
        public void Configure(EntityTypeBuilder<Song> builder)
        {
            ConfigureRealEntityBase(ref builder);
            builder.ToTable("Songs");
            builder.Property(x => x.TotalLike).IsRequired().HasDefaultValue(0);
            builder.Property(x => x.TotalCmt).IsRequired().HasDefaultValue(0);
            builder.Property(x => x.TotalListen).IsRequired().HasDefaultValue(0);
            builder.Property(x => x.TotalDownload).IsRequired().HasDefaultValue(0);
            builder.Property(x => x.Duration).IsRequired().HasDefaultValue(0);
            builder.Property(x => x.IsPublic).IsRequired();
            builder.Property(x => x.SongVip).IsRequired().HasDefaultValue(false);
            builder.Property(x => x.Country).IsRequired().HasDefaultValue("");
            builder.Property(x => x.IsChecked).IsRequired().HasDefaultValue(false);
            builder.Property(x => x.IsOfficial).IsRequired().HasDefaultValue(true);
            builder.Property(x => x.Thumbnail).IsRequired().HasDefaultValue("");
            builder.Property(x => x.FileMusic128).IsRequired().HasDefaultValue("");
            builder.Property(x => x.FileMusic320).HasDefaultValue("");
            builder.Property(x => x.FileMusicLossless).HasDefaultValue("");
            //builder.HasOne(x => x.FileMusic).WithOne(x => x.Song).HasForeignKey<FileMusic>(x => x.IdSong).OnDelete(DeleteBehavior.Cascade);
            //builder.HasMany(x => x.FileImages).WithOne(x => x.Song).HasForeignKey(x=>x.IdSong).OnDelete(DeleteBehavior.Cascade);
            //builder.Property(x => x.IdFileMusic);
            //builder.HasOne(x => x.FileMusic).WithOne(s => s.Song).HasForeignKey<FileMusic>(x => x.IdSong);

        }
    }
}
