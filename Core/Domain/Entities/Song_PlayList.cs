using Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Song_PlayList : AuditableBaseEntity
    {
        public int SongId { get; set; }
        public Song Song { get; set; }

        public int PlayListId { get; set; }
        public Playlist PlayList { get; set; }

    }
}
