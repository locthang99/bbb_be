using Application.Wrappers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThirdPartyServices.RedisCache;
using ThirdPartyServices.RedisCache.DTOs;

namespace BackendAPI.Controllers.v1
{
    [ApiVersion("1.0")]
    [ApiController]
    public class CacheController: BaseApiController
    {
        private readonly IRedisService _redisService;
        public CacheController(IRedisService redisService)
        {
            _redisService = redisService;
        }
        [HttpGet("GetCache")]
        public async Task<IActionResult> GetCache([FromQuery] string key, [FromQuery] int db)
        {
            var data = _redisService.Get(key, db);
            if (data != null)
                return Ok(new Response<object>()
                {
                    Code = 200,
                    Msg = "Get cache from key: " + key,
                    Data = data
                });
            else
                return NotFound(new Response<object>()
                {
                    Code = 404,
                    Msg = "Not found cache from key: " + key,
                    Data = null
                });
        }

        [HttpPost("SetCache")]
        public async Task<IActionResult> SetCache([FromBody] ObjectCache obj)
        {
            var data = _redisService.Set(obj);
            if (data)
                return Ok(new Response<object>()
                {
                    Code = 200,
                    Msg = "SET cache from key: " + obj.key,
                    Data = obj.value
                });
            else
                return BadRequest(new Response<object>()
                {
                    Code = 400,
                    Msg = "SET cache from key: " + obj.key+ " FAILED",
                    Data = null
                });
        }

        [HttpDelete("DeleteCache")]
        public async Task<IActionResult> DeleteCache([FromQuery] string key, [FromQuery] int db)
        {
            var data = _redisService.Delete(key, db);
            if (data)
                return Ok(new Response<object>()
                {
                    Code = 200,
                    Msg = "DELETE cache from key: " + key,
                    Data = null
                });
            else
                return BadRequest(new Response<object>()
                {
                    Code = 400,
                    Msg = "DELETE cache from key: " + key + " FAILED",
                    Data = null
                });
        }
    }
}
