using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Features.Song.DTO
{
    public class SongDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateCreate { get; set; }
        public int TotalListen { get; set; }
        public int TotalLike { get; set; }
        public int TotalCmt { get; set; }
        public int TotalDownload { get; set; }
        public string Lyric { get; set; }
        public string Thumbnail { get; set; }
        public string FileMusic { get; set; }
        public int Duration { get; set; }
        //public List<SongTypeModel> Types { get; set; }
        //public List<TagModel> Tags { get; set; }
        //public List<OwnerModel> Owners { get; set; }
    }
}
