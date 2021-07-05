using Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class InfoVipUser:AuditableBaseEntity
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public DateTime ExpireAt { get; set; }
        public string Status { get; set; }
    }
}
