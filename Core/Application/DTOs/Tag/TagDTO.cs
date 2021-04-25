using Application.DTOs.Owner;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.Tag
{
    public class TagDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateCreate { get; set; }
        public OwnerDTO Owner { get; set; } 
    }
}
