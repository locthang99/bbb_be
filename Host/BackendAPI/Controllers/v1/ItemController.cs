using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Application.Features.Item.Queries;
using Application.Features.Item.Commands;
using Application.Wrappers;
using ThirdPartyServices.Payment;
using ThirdPartyServices.Payment.DTO;
//using Application.Features.Tag.Commands;

namespace BackendAPI.Controllers.v1
{
    [ApiVersion("1.0")]
    public class ItemController : BaseApiController
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

        #endregion

        #region Commands
        [HttpPut("UpdatePriceDiscount")]
        public async Task<IActionResult> UpdatePriceDiscount([FromQuery] int Id,[FromBody] UpdatePriceDiscountCommand rq)
        {
            rq.SetId(Id);
            return Ok(await Mediator.Send(rq));
        }

        #endregion
    }
}
