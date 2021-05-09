using System;
using System.Collections.Generic;
using System.Text;
using ThirdPartyServices.RedisCache.DTOs;

namespace ThirdPartyServices.RedisCache
{
    public interface IRedisService
    {
        public string Get(string key,int db);
        public bool Set(ObjectCache obj);
        public bool Delete(string key,int db);
    }
}
