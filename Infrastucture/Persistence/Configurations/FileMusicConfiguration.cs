using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class FileMusicConfiguration : IEntityTypeConfiguration<FileMusic>
    {
        public void Configure(EntityTypeBuilder<FileMusic> builder)
        {
            builder.ToTable("FileMusics");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.IdSong);
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.Type).IsRequired();
            builder.Property(x => x.Path).IsRequired();
            builder.Property(x => x.FileSize).IsRequired();
            

        }
    }
}
