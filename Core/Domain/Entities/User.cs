using Domain.Base;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class User : AuditableBaseEntity
    {
        public virtual int AccessFailedCount { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Dob { get; set; }
        public string Address { get; set; }
        public string AccountType { get; set; }
        public string Thumbnail { get; set; }


        public virtual DateTimeOffset? LockoutEnd { get; set; }
        [PersonalData]
        public virtual bool TwoFactorEnabled { get; set; }
        [PersonalData]
        public virtual bool PhoneNumberConfirmed { get; set; }
        [ProtectedPersonalData]
        public virtual string PhoneNumber { get; set; }
        public virtual string ConcurrencyStamp { get; set; }
        public virtual string SecurityStamp { get; set; }
        public virtual string PasswordHash { get; set; }
        [PersonalData]
        public virtual bool EmailConfirmed { get; set; }
        public virtual string NormalizedEmail { get; set; }
        [ProtectedPersonalData]
        public virtual string Email { get; set; }
        public virtual string NormalizedUserName { get; set; }
        [ProtectedPersonalData]
        public virtual string UserName { get; set; }
        [PersonalData]
        public virtual bool LockoutEnabled { get; set; }



        //public List<FileImage> FileImages { get; set; }
        public List<User_Like_Song> ListSongLike { get; set; }
        public List<User_Cmt_Song> ListSongCmt { get; set; }
        public List<User_Like_Playlist> ListPlaylistLike { get; set; }
        public List<User_Cmt_Playlist> ListPlaylistCmt { get; set; }
        public List<Friend> ListFriendSend { get; set; }
        public List<Friend> ListFriendReceive { get; set; }
        public List<Song_Owner> Song_Owners { get; set; }
        //public List<PlayList> PlaylistPrivate { get; set; }

    }
}
