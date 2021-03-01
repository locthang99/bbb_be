using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.Configurations.BaseConfig;

namespace Persistence.Configurations
{
    public class FriendConfiguration : AuditableEntityConfiguration<Friend>, IEntityTypeConfiguration<Friend>
    {
        public void Configure(EntityTypeBuilder<Friend> builder)
        {
            ConfigureBase(ref builder);
            builder.ToTable("Friends");
            builder.Property(x => x.Status);
            builder.HasOne(s => s.Sender)
                .WithMany(pl => pl.ListFriendSend)
                .HasForeignKey(pl => pl.SenderId).HasPrincipalKey(t=>t.Id);
            builder.HasOne(pl => pl.Receiver).WithMany(s => s.ListFriendReceive)
              .HasForeignKey(s => s.ReceiverId).OnDelete(DeleteBehavior.NoAction).HasPrincipalKey(t => t.Id);
        }
    }
}
