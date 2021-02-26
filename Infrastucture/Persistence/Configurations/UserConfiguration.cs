using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.Property(x => x.FirstName).HasMaxLength(200).IsRequired();
            builder.Property(x => x.LastName).HasMaxLength(200).IsRequired();
            builder.Property(x => x.Dob);
            builder.Property(x => x.Thumbnail).IsRequired().HasDefaultValue("");
            builder.Property(x => x.SecurityStamp).IsRequired().HasDefaultValue("");
            builder.Property(x => x.AccountType).IsRequired();
            builder.Property(x => x.DateCreate).HasDefaultValue(DateTime.Now);
            //builder.HasMany(x => x.FileImages).WithOne(x => x.User).HasForeignKey(x => x.IdUser).OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(x => x.ListFriendSend).WithOne(x => x.Sender).HasForeignKey(x => x.Id).OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(x => x.ListFriendReceive).WithOne(x => x.Receiver).HasForeignKey(x => x.Id).OnDelete(DeleteBehavior.Cascade);
            //builder.HasMany(x => x.PlaylistPrivate).WithOne(x => x.Owner).HasForeignKey(x => x.OwnerId);

        }
    }
}
