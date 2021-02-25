using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Base
{
    public class RealEntity : AuditableBaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
