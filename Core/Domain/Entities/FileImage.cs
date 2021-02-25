using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class FileImage
    {
        public int Id { get; set; }
        public int? IdSong { get; set; }
        public int? IdPlayList { get; set; }
        public Guid? IdUser { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string Path { get; set; }
        public long FileSize { get; set; }
        public Song Song { get; set; }
        public Playlist PlayList { get; set; }
        public User User { get; set; }

    }
}
