using Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Song_Singer : ExtensionEntity
    {
        public int SongId { get; set; }
        public Song Song { get; set; }

        public int SingerId { get; set; }
        public User Singer { get; set; }

    }
}
