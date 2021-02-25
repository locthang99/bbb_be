using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Friend
    {
        public int Id { get; set; }
        public int SenderId { get; set; }
        public User Sender { get; set; }
        public int ReceiverId { get; set; }
        public User Receiver { get; set; }
        public int Status { get; set; }
    }
}
