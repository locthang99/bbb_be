using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.Configurations.BaseConfig;

namespace Persistence.Configurations
{
    public class FollowerConfiguration : ExtensionEntityConfiguration<Follower>, IEntityTypeConfiguration<Follower>
    {
        public void Configure(EntityTypeBuilder<Follower> builder)
        {
            ConfigureExtensionEntityBase(ref builder);
            builder.ToTable("Followers");
            builder.HasKey(t => new { t.SubscriberId, t.PublisherId });
            builder.Property(x => x.Status);
            builder.HasOne(s => s.Subscriber)
                .WithMany(pl => pl.ListSubscribers)
                .HasForeignKey(pl => pl.SubscriberId).HasPrincipalKey(t=>t.Id);
            builder.HasOne(pl => pl.Publisher).WithMany(s => s.ListPublishers)
              .HasForeignKey(s => s.PublisherId).OnDelete(DeleteBehavior.NoAction).HasPrincipalKey(t => t.Id);
        }
    }
}
