using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.Configurations.BaseConfig;

namespace Persistence.Configurations
{
    public class User_Like_PlaylistConfiguration : ExtensionEntityConfiguration<User_Like_Playlist>,IEntityTypeConfiguration<User_Like_Playlist>
    {
        public void Configure(EntityTypeBuilder<User_Like_Playlist> builder)
        {
            ConfigureExtensionEntityBase(ref builder);
            builder.HasKey(t => new { t.UserId, t.PlaylistId });
            builder.Property(t => t.DateCreate).IsRequired().HasDefaultValue(DateTime.Now);
            builder.Property(t => t.TotalLike).IsRequired().HasDefaultValue(0);
            builder.ToTable("User_Like_Playlist");
            builder.HasOne(s => s.PlayList).WithMany(u => u.ListUserLike)
                .HasForeignKey(u => u.PlaylistId);
            builder.HasOne(u => u.User).WithMany(s => s.ListPlaylistLike).HasForeignKey(s => s.UserId);
        }
    }

}
