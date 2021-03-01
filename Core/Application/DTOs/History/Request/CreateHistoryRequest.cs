using Application.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.History.Request
{
    public class CreateHistoryRequest
    {

        public ActionType ActionType { get; set; }
        public ObjectType ObjectType { get; set; }
        public string ObjectId { get; set; }
        public string ObjectName { get; set; }
    }
}
