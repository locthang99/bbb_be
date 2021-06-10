using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Application.Features.Type.Queries;
using Application.Features.Type.Commands;
using Microsoft.AspNetCore.Authorization;
//using Application.Features.Tag.Commands;

namespace BackendAPI.Controllers.v1
{
    [ApiVersion("1.0")]
    public class TypeController : BaseApiController
    {
        #region Queries
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

        [HttpGet("ListDeleted")]
        public async Task<IActionResult> GetListDeleted([FromQuery] GetListDeletedQuery rq)
        {
            return Ok(await Mediator.Send(rq));
        }

        [HttpGet("GetSong")]
        public async Task<IActionResult> GetSong([FromQuery] GetSongQuery rq)
        {
            return Ok(await Mediator.Send(rq));
        }
        #endregion

        #region Command
        [HttpPost]
        public async Task<IActionResult> Create([FromForm] CreateCommand rq)
        {
            return Ok(await Mediator.Send(rq));
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromQuery] int Id, [FromForm] UpdateCommand rq)
        {
            rq.SetId(Id);
            return Ok(await Mediator.Send(rq));
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromQuery] int Id)
        {
            var rq = new DeleteCommand();
            rq.SetId(Id);
            return Ok(await Mediator.Send(rq));
        }

        [HttpPut("UnDelete")]
        [Authorize]
        public async Task<IActionResult> UnDelete([FromQuery] int Id)
        {
            var rq = new UnDeleteCommand();
            rq.SetId(Id);
            return Ok(await Mediator.Send(rq));
        }

        [HttpDelete("StrongDelete")]
        [Authorize]
        public async Task<IActionResult> StrongDelete([FromQuery] int Id)
        {
            var rq = new StrongDeleteCommand();
            rq.SetId(Id);
            return Ok(await Mediator.Send(rq));
        }

        #endregion
    }
}
