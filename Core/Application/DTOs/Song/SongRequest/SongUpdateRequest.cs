using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.Song.SongRequest
{
    public class SongUpdateRequest
    {
        //public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IFormFile Lyric { get; set; }
        public int Duration { get; set; }
        public bool IsPublic { get; set; }
        public IFormFile Thumbnail { get; set; }
        public IFormFile FileMusic { get; set; }
        public List<int> Types { get; set; }
        public List<int> Tags { get; set; }
    }
}
