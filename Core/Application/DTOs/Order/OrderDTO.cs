using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.Order
{
    public class OrderDTO
    {

        public int UserId { get; set; }
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public string Name { get; set; }
        public DateTime DateCreate { get; set; }
        public long Amount { get; set; }
        public int DiscountAdded { get; set; }
        public string Status { get; set; }
    }
}
