using Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Follower : ExtensionEntity
    {
        public int SubscriberId { get; set; }
        public User Subscriber { get; set; }
        public int PublisherId { get; set; }
        public User Publisher { get; set; }
        public int Status { get; set; }
    }
}
