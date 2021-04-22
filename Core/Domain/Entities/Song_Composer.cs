using Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Song_Composer : ExtensionEntity
    {
        public int SongId { get; set; }
        public Song Song { get; set; }

        public int ComposerId { get; set; }
        public User Composer { get; set; }

    }
}
