using Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Song_Owner : AuditableBaseEntity
    {
        public int SongId { get; set; }
        public Song Song { get; set; }

        public int OwnerId { get; set; }
        public User Owner { get; set; }
    }
}
