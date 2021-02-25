using Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class User_Cmt_Playlist : ExtensionEntity
    {
        public User User { get; set; }
        public int PlaylistId { get; set; }
        public Playlist PlayList { get; set; }
        public string Content { get; set; }
    }
}
