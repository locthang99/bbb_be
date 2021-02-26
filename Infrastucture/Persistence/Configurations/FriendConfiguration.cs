using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class FriendConfiguration : IEntityTypeConfiguration<Friend>
    {
        public void Configure(EntityTypeBuilder<Friend> builder)
        {
            builder.ToTable("Friends");
            builder.HasKey(t =>t.Id);
            builder.Property(x => x.DateCreate).IsRequired().HasDefaultValue(DateTime.Now);
            builder.Property(x => x.LastModified);
            builder.Property(x => x.Status);
            builder.HasOne(s => s.Sender)
                .WithMany(pl => pl.ListFriendSend)
                .HasForeignKey(pl => pl.SenderId).HasPrincipalKey(t=>t.Id);
            builder.HasOne(pl => pl.Receiver).WithMany(s => s.ListFriendReceive)
              .HasForeignKey(s => s.ReceiverId).OnDelete(DeleteBehavior.NoAction).HasPrincipalKey(t => t.Id);
        }
    }
}
