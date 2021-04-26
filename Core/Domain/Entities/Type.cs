using Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Type : RealEntity
    {
        public string Thumbnail { get; set; }
        public List<Song_Type> Song_Types { get; set; }
    }
}
