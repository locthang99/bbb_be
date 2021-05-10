using Microsoft.Extensions.Configuration;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ThirdPartyServices.RedisCache.DTOs;

namespace ThirdPartyServices.RedisCache
{
    public class RedisService : IRedisService
    {
        private readonly int timeExpire = 1440;
        private readonly ConnectionMultiplexer muxer;

        public RedisService(IConfiguration config)
        {
            muxer = ConnectionMultiplexer.Connect(config["Redis:Host"]);
        }
        public async Task<string> Get(string key,int db)
        {
            return await muxer.GetDatabase(db).StringGetAsync(key);
        }

        public async Task<bool> Set(ObjectCache obj)
        {
            
            if (obj.timeExpire > 0)
            {
                var time = TimeSpan.FromHours(obj.timeExpire);
                return await muxer.GetDatabase(obj.db).StringSetAsync(obj.key, obj.value, time);
            }
            else
                return muxer.GetDatabase(obj.db).StringSet(obj.key, obj.value,null);
        }
        public async Task<bool> Delete(string key,int db)
        {
            return await muxer.GetDatabase(db).KeyDeleteAsync(key);
        }
    }
}
