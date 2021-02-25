using Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Song_Tag : AuditableBaseEntity
    {
        public int SongId { get; set; }
        public Song Song { get; set; }

        public int TagId { get; set; }
        public Tag Tag { get; set; }
    }
}
