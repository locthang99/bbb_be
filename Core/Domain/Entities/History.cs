using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class History
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public DateTime DateTime { get; set; }
        public string ActionType { get; set; }
        public string ObjectType { get; set; }
        public string ObjectId { get; set; }
        public string ObjectName { get; set; }
    }
}
