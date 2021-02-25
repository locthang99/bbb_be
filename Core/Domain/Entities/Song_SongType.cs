using Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Song_SongType : AuditableBaseEntity
    {
        public int SongId { get; set; }
        public Song Song { get; set; }

        public int SongTypeId { get; set; }
        public SongType SongType { get; set; }

    }
}
