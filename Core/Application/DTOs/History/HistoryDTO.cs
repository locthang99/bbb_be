using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.History
{
    public class HistoryDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime DateTime { get; set; }
        public string ActionType { get; set; }
        public string ObjectType { get; set; }        
        public string ObjectId { get; set; }
        public string ObjectName { get; set; }
    }
}
