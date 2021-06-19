using Application.DTOs.Owner;
using Application.DTOs.Song;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.Type
{
    public class TypeDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateCreate { get; set; }
        public string Thumbnail { get; set; }
        public OwnerDTO Owner { get; set; }
        //public List<SongModel> ListSong { get; set; }
    }
    public class TypeValueDTO : TypeDTO
    {
        public int Value { get; set; }
    }
}
