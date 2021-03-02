using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Application.Features.Song.Queries;

namespace BackendAPI.Controllers.v1
{
    [ApiVersion("1.0")]
    public class SongController : BaseApiController
    {
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetAllQuery rq)
        {

            return Ok(await Mediator.Send(rq));
        }

        [HttpGet("ById")]
        public async Task<IActionResult> Get([FromQuery] GetByIdQuery rq)
        {

            return Ok(await Mediator.Send(rq));
        }

        [HttpGet("ByListId")]
        public async Task<IActionResult> GetByListId([FromQuery] GetByListIdQuery rq)
        {

            return Ok(await Mediator.Send(rq));
        }

        [HttpGet("ByName")]
        public async Task<IActionResult> GetByName([FromQuery] GetByNameQuery rq)
        {
            return Ok(await Mediator.Send(rq));
        }
    }
}
