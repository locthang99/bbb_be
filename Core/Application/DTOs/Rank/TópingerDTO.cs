using Application.DTOs.Owner;
using Application.DTOs.Song;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.Rank
{
    public class TopSingerDTO
    {
        public string Title { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public List<SingerDTO> Singers { get; set; }
    }
}
