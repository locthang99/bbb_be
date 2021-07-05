using Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Order : RealEntity
    {
        public int UserId { get; set; }
        public int ItemId { get; set; }
        public long Amount { get; set; }
        public int DiscountAdded { get; set; }
        public string Status { get; set; }

    }
}
