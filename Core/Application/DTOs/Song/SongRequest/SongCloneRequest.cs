using Application.DTOs.Owner;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.Song.SongRequest
{
    public class SongCloneRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Lyric { get; set; }
        public int TotalListen { get; set; }
        public int Duration { get; set; }
        public string Thumbnail { get; set; }
        public string FileMusic { get; set; }
        public List<SingerDTO> singerClones { get; set; }
    }
}
