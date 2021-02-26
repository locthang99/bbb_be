using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class User_Like_PlaylistConfiguration : IEntityTypeConfiguration<User_Like_Playlist>
    {
        public void Configure(EntityTypeBuilder<User_Like_Playlist> builder)
        {
            builder.HasKey(t => new { t.UserId, t.PlaylistId });
            builder.Property(t => t.DateCreate).IsRequired().HasDefaultValue(DateTime.Now);
            builder.ToTable("User_Like_Playlist");
            builder.HasOne(s => s.PlayList).WithMany(u => u.ListUserLike)
                .HasForeignKey(u => u.PlaylistId);
            builder.HasOne(u => u.User).WithMany(s => s.ListPlaylistLike).HasForeignKey(s => s.UserId);
        }
    }

}
