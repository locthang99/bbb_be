using Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class User_Like_Playlist : ExtensionEntity
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int PlaylistId { get; set; }
        public Playlist PlayList { get; set; }
    }
}
