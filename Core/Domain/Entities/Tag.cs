using Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Tag : RealEntity
    {
        public List<Song_Tag> Song_Tags { get; set; }
    }
}
