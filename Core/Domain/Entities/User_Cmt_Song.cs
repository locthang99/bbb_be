using Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class User_Cmt_Song : AuditableBaseEntity
    {
        public User User { get; set; }
        public int SongId { get; set; }
        public Song Song { get; set; }
        public string Content { get; set; }
    }
}
