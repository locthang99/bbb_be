using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.User
{
    public class FriendDTO
    {
        public int SenderId { get; set; }
        public string SenderName { get; set; }
        public int ReceiverId { get; set; }
        public string ReceiverName { get; set; }
        public string Status { get; set; }
        public DateTime DateSendRequest { get; set; }
        public DateTime DateUpdateRequest { get; set; }
    }
}
