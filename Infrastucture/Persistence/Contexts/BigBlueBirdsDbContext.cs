using Application.Interfaces.Service;
using Domain.Base;
using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
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
    public class BigBlueBirdsDbContext : IdentityDbContext<User, Role, int,IdentityUserClaim<int>,IdentityUserRole<int>,IdentityUserLogin<int>,IdentityRoleClaim<int>,IdentityUserToken<int>>
    {

        public BigBlueBirdsDbContext(DbContextOptions options) : base(options)
        {
            //ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        //public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        //{
        //    foreach (var entry in ChangeTracker.Entries<AuditableBaseEntity>())
        //    {
        //        switch (entry.State)
        //        {
        //            case EntityState.Added:
        //                entry.Entity.DateCreate = DateTime.UtcNow;
        //                entry.Entity.CreatedBy ??= _authenticatedUser.GetCurrentUserId();
        //                break;
        //            case EntityState.Modified:
        //                entry.Entity.LastModified = DateTime.UtcNow;
        //                entry.Entity.LastModifiedBy ??= _authenticatedUser.GetCurrentUserId();
        //                break;
        //        }
        //    }
        //    return base.SaveChangesAsync(cancellationToken);
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AppConfigConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new SongConfiguration());
            modelBuilder.ApplyConfiguration(new SongTypeConfiguration());
            modelBuilder.ApplyConfiguration(new PlaylistConfiguration());
            modelBuilder.ApplyConfiguration(new Song_PlayListConfiguration());
            modelBuilder.ApplyConfiguration(new Song_SongTypeConfiguration());
            modelBuilder.ApplyConfiguration(new Song_OwnerConfiguration());
            modelBuilder.ApplyConfiguration(new User_Like_SongConfiguration());
            modelBuilder.ApplyConfiguration(new User_Cmt_SongConfiguration());
            modelBuilder.ApplyConfiguration(new FriendConfiguration());
            modelBuilder.ApplyConfiguration(new FileImageConfiguration());
            modelBuilder.ApplyConfiguration(new FileMusicConfiguration());
            modelBuilder.ApplyConfiguration(new HistoryConfiguration());
            modelBuilder.ApplyConfiguration(new TagConfiguration());
            modelBuilder.ApplyConfiguration(new Song_TagConfiguration());
            modelBuilder.ApplyConfiguration(new CacheDataConfiguration());

            modelBuilder.Entity<IdentityUserClaim<int>>().ToTable("UserClaims");
            modelBuilder.Entity<IdentityUserRole<int>>().ToTable("UserRoles").HasKey(x => new { x.UserId, x.RoleId });
            modelBuilder.Entity<IdentityUserLogin<int>>().ToTable("UserLogins").HasKey(x => x.UserId);
            modelBuilder.Entity<IdentityRoleClaim<int>>().ToTable("UserRoleClaims");
            modelBuilder.Entity<IdentityUserToken<int>>().ToTable("UserTokens").HasKey(x => x.UserId);
            //base.OnModelCreating(modelBuilder);
            //modelBuilder.Seed();
            modelBuilder.SeedAccount();
            modelBuilder.SeedRole();
            modelBuilder.SeedAccount_Role();
            modelBuilder.SeedSongType();
        }
        public DbSet<AppConfig> AppConfig { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<Playlist> Playlists { get; set; }
        public DbSet<SongType> SongTypes { get; set; }
        public DbSet<Song_SongType> Song_SongTypes { get; set; }
        public DbSet<Song_PlayList> Song_PlayLists { get; set; }
        public DbSet<Song_Owner> Song_Owers { get; set; }
        public DbSet<User_Like_Song> User_Like_Songs { get; set; }
        public DbSet<User_Cmt_Song> User_Cmt_Songs { get; set; }
        public DbSet<User_Like_Playlist> User_Like_Playlists { get; set; }
        public DbSet<User_Cmt_Playlist> User_Cmt_Playlists { get; set; }
        public DbSet<Friend> Friends { get; set; }
        public DbSet<FileImage> FileImages { get; set; }
        public DbSet<FileMusic> FileMusics { get; set; }
        public DbSet<History> Histories { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Song_Tag> Song_Tags { get; set; }
        public DbSet<CacheData> CacheDatas { get; set; }

    }
}
