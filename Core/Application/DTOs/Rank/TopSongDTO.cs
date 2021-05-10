using Application.DTOs.Song;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.Rank
{
    public class TopSongDTO
    {
        public string Title { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public List<SongDTO> Songs { get; set; }
    }
}
