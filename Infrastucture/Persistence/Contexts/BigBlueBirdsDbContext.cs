using Domain.Base;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Configurations;
using Persistence.Seed;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Persistence.Contexts
{
    public class BigBlueBirdsDbContext : DbContext
    {
        public BigBlueBirdsDbContext(DbContextOptions options) : base(options)
        {
            //ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableBaseEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.DateCreate = DateTime.UtcNow;
                        entry.Entity.CreatedBy = "Admin 1";
                        break;
                    case EntityState.Modified:
                        entry.Entity.LastModified = DateTime.UtcNow;
                        entry.Entity.LastModifiedBy = "Admin 2";
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }
        public DbSet<Product> AppConfig { get; set; }
        //public DbSet<AppConfig> AppConfig { get; set; }
        //public DbSet<Song> Songs { get; set; }
        //public DbSet<PlayList> PlayLists { get; set; }
        //public DbSet<SongType> SongTypes { get; set; }
        //public DbSet<Song_SongType> Song_SongTypes { get; set; }
        //public DbSet<Song_PlayList> Song_PlayLists { get; set; }
        //public DbSet<Song_Owner> Song_Owers { get; set; }
        //public DbSet<User_Like_Song> User_Like_Songs { get; set; }
        //public DbSet<User_Cmt_Song> User_Cmt_Songs { get; set; }
        //public DbSet<User_Like_Playlist> User_Like_Playlists { get; set; }
        //public DbSet<User_Cmt_Playlist> User_Cmt_Playlists { get; set; }
        //public DbSet<Friend> Friends { get; set; }
        //public DbSet<FileImage> FileImages { get; set; }
        //public DbSet<FileMusic> FileMusics { get; set; }
        //public DbSet<History> Histories { get; set; }
        //public DbSet<Tag> Tags { get; set; }
        //public DbSet<Song_Tag> Song_Tags { get; set; }
        //public DbSet<CacheData> CacheDatas { get; set; }

    }
}
