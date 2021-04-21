using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.Configurations.BaseConfig;

namespace Persistence.Configurations
{
    public class User_Like_SongConfiguration : ExtensionEntityConfiguration<User_Like_Song>,IEntityTypeConfiguration<User_Like_Song>
    {
        public void Configure(EntityTypeBuilder<User_Like_Song> builder)
        {
            ConfigureExtensionEntityBase(ref builder);
            builder.HasKey(t => new { t.UserId, t.SongId });
            builder.Property(t => t.DateCreate).IsRequired().HasDefaultValue(DateTime.Now);
            builder.Property(t => t.TotalLike).IsRequired().HasDefaultValue(0);
            builder.ToTable("User_Like_Song");
            builder.HasOne(s => s.Song).WithMany(u => u.ListUserLike)
                .HasForeignKey(u => u.SongId);
            builder.HasOne(u => u.User).WithMany(s => s.ListSongLike)
              .HasForeignKey(s => s.UserId);
        }
    }

}
