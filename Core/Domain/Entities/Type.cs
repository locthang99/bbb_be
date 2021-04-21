using Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Type : RealEntity
    {
        public List<Song_Type> Song_Types { get; set; }
    }
}
