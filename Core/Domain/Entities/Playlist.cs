using Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class PlayList : RealEntity
    {

        public string Thumbnail { get; set; }
        public int TotalSong { get; set; }
        public int TotalListen { get; set; }
        public int TotalLike { get; set; }
        public int TotalCmt { get; set; }
        public string PlaylistType { get; set; }

        public List<Song_PlayList> Song_PlayLists { get; set; }
        //public List<FileImage> FileImages { get; set; }

        public List<User_Like_Playlist> ListUserLike { get; set; }
        public List<User_Cmt_Playlist> ListUserCmt { get; set; }
        //public User Owner { get; set; }
        public int OwnerId { get; set; }
    }
}
