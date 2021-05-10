using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ThirdPartyServices.RedisCache.DTOs;

namespace ThirdPartyServices.RedisCache
{
    public interface IRedisService
    {
        public Task<string> Get(string key,int db);
        public Task<bool> Set(ObjectCache obj);
        public Task<bool> Delete(string key,int db);
    }
}
