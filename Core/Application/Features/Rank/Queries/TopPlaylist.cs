using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.DTOs.Rank;
using Application.DTOs.Song;
using Application.Exceptions;
using Application.Interfaces.Repo;
using Application.Parameters;
using Application.Wrappers;
using MediatR;
using Newtonsoft.Json;
using ThirdPartyServices.RedisCache;

namespace Application.Features.Rank.Queries
{
    public class GetTopPlaylistQuery : IRequest<Response<TopPlaylistDTO>>
    {
        public int Month { get; set; }
        public int Year { get; set; }
    }
    public class GetTopPlaylistHandler : IRequestHandler<GetTopPlaylistQuery, Response<TopPlaylistDTO>>
    {
        private readonly IRedisService _redisService;
        public GetTopPlaylistHandler(IRedisService redisService)
        {
            _redisService = redisService;
        }
        public async Task<Response<TopPlaylistDTO>> Handle(GetTopPlaylistQuery request, CancellationToken cancellationToken)
        {
            var key = string.Format("TopPlaylist_{0}_{1}", request.Month, request.Year);
            var cacheTop = await _redisService.Get(key, 0);
            if (cacheTop == null)
                throw new BadRequestException("Don't has data at " + request.Month + "/" + request.Year);
            var obj = JsonConvert.DeserializeObject<TopPlaylistDTO>(cacheTop);
            return new Response<TopPlaylistDTO>()
            {
                Data = obj
            };
        }
    }
}
