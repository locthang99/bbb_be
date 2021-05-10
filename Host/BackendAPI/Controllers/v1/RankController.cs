using Application.Features.Rank.Queries;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BackendAPI.Controllers.v1
{
    [ApiVersion("1.0")]
    [ApiController]
    public class RankController : BaseApiController
    {
        [HttpGet("TopSong")]
        public async Task<IActionResult> GetTopSong([FromQuery] GetTopSongQuery rq)
        {
            return Ok(await Mediator.Send(rq));
        }

        [HttpGet("TopPlaylist")]
        public async Task<IActionResult> GetTopPlaylist([FromQuery] GetTopPlaylistQuery rq)
        {
            return Ok(await Mediator.Send(rq));
        }

        [HttpGet("TopSinger")]
        public async Task<IActionResult> GetTopSinger([FromQuery] GetTopSingerQuery rq)
        {
            return Ok(await Mediator.Send(rq));
        }
    }
}
