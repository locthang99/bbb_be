using Application.DTOs.User;
using Application.Exceptions;
using Application.Wrappers;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ThirdPartyServices.RedisCache;

namespace Application.Features.Account.EndUser.Queries
{
    public class GetTempUserIdQuery : IRequest<Response<object>>
    {
        public string DeviceId { get; set; }
    }
    public class GetTempUserIdQueryHandler : IRequestHandler<GetTempUserIdQuery, Response<object>>
    {
        private readonly IRedisService _redisService;
        public GetTempUserIdQueryHandler(IRedisService redisService)
        {
            _redisService = redisService;
        }
        public async Task<Response<object>> Handle(GetTempUserIdQuery request, CancellationToken cancellationToken)
        {
            var userId = await _redisService.Get(request.DeviceId,3);
            if(userId ==null)
            {
                var randomUserId = new Random().Next(10000, 50000);
                if(await _redisService.Set(new ThirdPartyServices.RedisCache.DTOs.ObjectCache()
                {
                    key = request.DeviceId,
                    value = randomUserId.ToString(),
                    db =3,
                    timeExpire = 0
                }))
                {
                    return new Response<object>()
                    {
                        Msg = "GetTempUserId OK",
                        Data = new { TempUserId = randomUserId }
                    };
                }
                else
                {
                    throw new BadRequestException("Failed");
                }
            }
            else
            {
                return new Response<object>()
                {
                    Msg = "GetTempUserId OK",
                    Data = new { TempUserId = Int32.Parse(userId)}
                };
            }

        }
    }
}
