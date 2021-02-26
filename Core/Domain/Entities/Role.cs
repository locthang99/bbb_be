//using Microsoft.AspNetCore.Identity;
using Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Role : AuditableBaseEntity
    {
        public virtual string Name { get; set; }
        public virtual string NormalizedName { get; set; }
        public virtual string ConcurrencyStamp { get; set; }
    }
}
