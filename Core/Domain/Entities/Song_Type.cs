using Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Song_Type : ExtensionEntity
    {
        public int SongId { get; set; }
        public Song Song { get; set; }

        public int TypeId { get; set; }
        public Type Type { get; set; }

        public int Value { get; set; }

    }
}
