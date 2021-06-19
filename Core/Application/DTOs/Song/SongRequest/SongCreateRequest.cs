using Microsoft.AspNetCore.Http;
using Application.DTOs.Type;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace Application.DTOs.Song.SongRequest
{
    public class SongCreateRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public IFormFile Lyric { get; set; }
        public int Duration { get; set; }
        public IFormFile Thumbnail { get; set; }
        public IFormFile FileMusic128 { get; set; }
        public IFormFile FileMusic320 { get; set; }
        public IFormFile FileMusicLossless { get; set; }
        public bool IsPublic { get; set; }
        public bool IsOfficial { get; set; }
        public string Country { get; set; }

    }
}
