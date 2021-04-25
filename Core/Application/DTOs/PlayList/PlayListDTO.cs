using Application.DTOs.Owner;
using Application.DTOs.Song;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.PlayList
{
    public class PlaylistDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateCreate { get; set; }
        public int TotalSong { get; set; }
        public int TotalListen { get; set; }
        public int TotalLike { get; set; }
        public int TotalCmt { get; set; }
        public string Thumbnail { get; set; }
        public string PlaylistType { get; set; }
        public OwnerDTO Owner { get; set; }
        public List<SongDTO> ListSong { get; set; }

    }
}
