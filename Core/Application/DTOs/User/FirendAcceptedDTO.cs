using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.User
{
    public class FirendAcceptedDTO
    {
        public int FriendId { get; set; }
        public string FriendName { get; set; }
        public string Status { get; set; }
        public DateTime DateSendRequest { get; set; }
        public DateTime DateAcceptedRequest { get; set; }
    }
}
