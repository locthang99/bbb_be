using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class FileImageConfiguration : IEntityTypeConfiguration<FileImage>
    {
        public void Configure(EntityTypeBuilder<FileImage> builder)
        {
            builder.ToTable("FileImages");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.IdSong);
            builder.Property(x => x.IdPlayList);
            builder.Property(x => x.IdUser);
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.Type).IsRequired();
            builder.Property(x => x.Path).IsRequired();
            builder.Property(x => x.FileSize).IsRequired();
            //builder.HasOne(x => x.Song).WithMany(x => x.FileImages).HasForeignKey(x => x.IdSong);
            //builder.HasOne(x => x.PlayList).WithMany(x => x.FileImages).HasForeignKey(x => x.IdPlayList);
            //builder.HasOne(x => x.User).WithMany(x => x.FileImages).HasForeignKey(x => x.IdUser);

        }
    }
}
