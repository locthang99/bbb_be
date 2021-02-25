using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Base
{
    public class ExtensionEntity : AuditableBaseEntity
    {
        public virtual bool CompareTwoId(int id1, int id2) { return false; }
    }
}
