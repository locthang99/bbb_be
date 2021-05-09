using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdPartyServices.RedisCache.DTOs
{
    public class ObjectCache
    {
        public string key { get; set; }
        public string value { get; set; }
        public int timeExpire { get; set; }
        public int db { get; set; }



    }
}
