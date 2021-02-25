using Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class SongType : RealEntity
    {
        public List<Song_SongType> Song_SongTypes { get; set; }
    }
}
