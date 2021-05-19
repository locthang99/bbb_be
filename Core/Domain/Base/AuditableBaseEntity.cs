using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Base
{
    public abstract class AuditableBaseEntity
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int Id { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime DateCreate { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModified { get; set; }
        public bool Disable { get; set; }
        public bool IsDelete { get; set; }
    }
}
