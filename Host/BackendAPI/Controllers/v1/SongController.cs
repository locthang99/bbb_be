using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Application.Features.Song.Queries;
using Application.Features.Song.Commands;

namespace BackendAPI.Controllers.v1
{
    [ApiVersion("1.0")]
    public class SongController : BaseApiController
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

        [HttpPut("{Id}/UpdateType/{IdType}")]
        public async Task<IActionResult> UpdateType(int Id, int IdType)
        {
            var rq = new UpdateTypeCommand() { Id = Id, IdTypeUpdate = IdType };
            return Ok(await Mediator.Send(rq));
        }

        [HttpPut("{Id}/UpdateTag/{IdTag}")]
        public async Task<IActionResult> UpdateTag(int Id, int IdTag)
        {
            var rq = new UpdateTagCommand() { Id = Id, IdTagUpdate = IdTag };
            return Ok(await Mediator.Send(rq));
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromQuery] int Id)
        {
            var rq = new DeleteCommand();
            rq.SetId(Id);
            return Ok(await Mediator.Send(rq));
        }
        #endregion
    }
}
