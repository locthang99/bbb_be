using System;
using System.Collections.Generic;
using System.Text;
using Domain.Base;

namespace Domain.Entities
{
    public class CacheData: AuditableBaseEntity
    {
        public string OwnerId { get; set; }
        public string Data { get; set; }
        public string Type { get; set; }
        public int TimeExpire { get; set; }
    }
}
