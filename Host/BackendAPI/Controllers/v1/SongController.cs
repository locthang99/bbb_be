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

            return Ok(await Mediator.Send(new GetAllQuery()
            { _pagedSortRequest = new Application.Parameters.PagedSortRequest { Index = 1, PageSize = 10, SortASC = true, SortBy = "Id" } }));
        }
    }
}
