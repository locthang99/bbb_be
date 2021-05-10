using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.DTOs.Owner;
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
    public class GetTopSingerQuery : IRequest<Response<TopSingerDTO>>
    {
        public int Month { get; set; }
        public int Year { get; set; }
    }
    public class GetTopSingerHandler : IRequestHandler<GetTopSingerQuery, Response<TopSingerDTO>>
    {
        private readonly IRedisService _redisService;
        public GetTopSingerHandler(IRedisService redisService)
        {
            _redisService = redisService;
        }
        public async Task<Response<TopSingerDTO>> Handle(GetTopSingerQuery request, CancellationToken cancellationToken)
        {
            var key = string.Format("TopSong_{0}_{1}", request.Month, request.Year);
            var cacheTop = await _redisService.Get(key, 0);
            if (cacheTop == null)
                throw new BadRequestException("Don't has data at " + request.Month + "/" + request.Year);
            var objTopSong = JsonConvert.DeserializeObject<TopSongDTO>(cacheTop);
            Dictionary<int, SingerDTO> listSigner = new Dictionary<int, SingerDTO>();
            foreach(var songs in objTopSong.Songs)
            {
                foreach (var singer in songs.Singers)
                {
                    if (!listSigner.ContainsKey(singer.SingerId))
                        listSigner.Add(singer.SingerId,singer);
                }
            }

            var objTopSinger = new TopSingerDTO()
            {
                Title = string.Format("Top Singer {0}/{1}", request.Month, request.Year),
                Month = request.Month,
                Year = request.Year,
                Singers = listSigner.Values.Take(5).ToList()
            };
            return new Response<TopSingerDTO>()
            {
                Data = objTopSinger
            };
        }
    }
}
