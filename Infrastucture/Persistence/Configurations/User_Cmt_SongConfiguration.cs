using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class User_Cmt_SongConfiguration : IEntityTypeConfiguration<User_Cmt_Song>
    {
        public void Configure(EntityTypeBuilder<User_Cmt_Song> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.SongId).IsRequired();
            builder.Property(t => t.UserId).IsRequired();
            builder.Property(t => t.DateCreate).IsRequired().HasDefaultValue(DateTime.Now);
            builder.Property(t => t.Content).IsRequired().HasMaxLength(1000);
            builder.ToTable("User_Cmt_Song");
            builder.HasOne(s => s.Song).WithMany(u => u.ListUserCmt)
                .HasForeignKey(u => u.SongId);
            builder.HasOne(u => u.User).WithMany(s => s.ListSongCmt)
              .HasForeignKey(s => s.UserId);
        }
    }

}
