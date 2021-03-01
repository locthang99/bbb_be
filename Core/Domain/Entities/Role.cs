//using Microsoft.AspNetCore.Identity;
using Domain.Base;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Role : IdentityRole<int>
    {
        public string CreatedBy { get; set; }
        public DateTime DateCreate { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModified { get; set; }
    }
}
