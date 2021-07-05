using Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Item : RealEntity
    {
        public string Thumbnail { get; set; }
        public long Price { get; set; }
        public int Discount { get; set; }
        public int AddTime { get; set; }
        public string TypeUpdate { get; set; }
    }
}
