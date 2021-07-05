using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.Item
{
    public class ItemDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Thumbnail { get; set; }
        public long Price { get; set; }
        public int Discount { get; set; }
        public int AddTime { get; set; }
        public DateTime DateCreate { get; set; }
        public string TypeUpdate { get; set; }
    }
}
