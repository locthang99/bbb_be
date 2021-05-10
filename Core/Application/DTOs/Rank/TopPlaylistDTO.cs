using Application.DTOs.PlayList;
using Application.DTOs.Song;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.Rank
{
    public class TopPlaylistDTO
    {
        public string Title { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public List<PlaylistDTO> Playlists { get; set; }
    }
}
