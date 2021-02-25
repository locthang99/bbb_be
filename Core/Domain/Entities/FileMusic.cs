using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class FileMusic
    {
        public int Id { get; set; }
        public int IdSong { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string Path { get; set; }
        public long FileSize { get; set; }
        public Song Song { get; set; }
    }
}
