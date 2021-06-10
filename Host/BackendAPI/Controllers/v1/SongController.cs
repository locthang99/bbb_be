using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Application.Features.Song.Queries;
using Application.Features.Song.Commands;
using Microsoft.AspNetCore.Authorization;

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

        [HttpGet("ListDeleted")]
        public async Task<IActionResult> GetListDeleted([FromQuery] GetListDeletedQuery rq)
        {
            return Ok(await Mediator.Send(rq));
        }

        [HttpGet("MySong")]
        public async Task<IActionResult> GetMySong([FromQuery] GetPrivateQuery rq)
        {
            return Ok(await Mediator.Send(rq));
        }

        [HttpGet("Comment")]
        public async Task<IActionResult> GetComment([FromQuery] GetCommentQuery rq)
        {
            return Ok(await Mediator.Send(rq));
        }

        [HttpGet("CheckLike")]
        public async Task<IActionResult> CheckLike([FromQuery] CheckLikeQuery rq)
        {
            return Ok(await Mediator.Send(rq));
        }
        [HttpPut("Listen")]
        public async Task<IActionResult> Listen([FromQuery] ListenCommand rq)
        {
            return Ok(await Mediator.Send(rq));
        }

        [HttpGet("Predict")]
        public async Task<IActionResult> Predict([FromQuery] PredictQuery rq)
        {
            return Ok(await Mediator.Send(rq));
        }
        #endregion

        #region Command
        [HttpPost]
        [Authorize]
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

        [HttpPut("{SongId}/UpdateType/{TypeId}")]
        public async Task<IActionResult> UpdateType(int SongId, int TypeId)
        {
            var rq = new UpdateTypeCommand() { Id = SongId, IdTypeUpdate = TypeId };
            return Ok(await Mediator.Send(rq));
        }

        [HttpPut("{SongId}/UpdateTag/{TagId}")]
        public async Task<IActionResult> UpdateTag(int SongId, int TagId)
        {
            var rq = new UpdateTagCommand() { Id = SongId, IdTagUpdate = TagId };
            return Ok(await Mediator.Send(rq));
        }

        [HttpPut("{SongId}/UpdateComposer/{ComposerId}")]
        public async Task<IActionResult> UpdateComposer(int SongId, int ComposerId)
        {
            var rq = new UpdateComposerCommand() { Id = SongId, IdComposerUpdate = ComposerId };
            return Ok(await Mediator.Send(rq));
        }

        [HttpPut("{SongId}/UpdateSinger/{SingerId}")]
        public async Task<IActionResult> UpdateSinger(int SongId, int SingerId)
        {
            var rq = new UpdateSingerCommand() { Id = SongId, IdSingerUpdate = SingerId };
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

        [HttpPost("Reaction")]
        public async Task<IActionResult> Reaction([FromQuery] ReactionCommand rq)
        {
            return Ok(await Mediator.Send(rq));
        }

        [HttpPost("Comment")]
        public async Task<IActionResult> Comment([FromBody] CommentCommand rq)
        {
            return Ok(await Mediator.Send(rq));
        }
        #endregion
    }
}
