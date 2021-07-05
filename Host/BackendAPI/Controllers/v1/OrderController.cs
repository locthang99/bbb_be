using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Application.Features.Order.Queries;
using Application.Features.Order.Commands;
using Application.Wrappers;
using ThirdPartyServices.Payment;
using ThirdPartyServices.Payment.DTO;
//using Application.Features.Tag.Commands;

namespace BackendAPI.Controllers.v1
{
    [ApiVersion("1.0")]
    public class OrderController : BaseApiController
    {
        #region Queries

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetAllQuery rq)
        {
            return Ok(await Mediator.Send(rq));
        }
        [HttpGet("MyOrder")]
        public async Task<IActionResult> GetMyOrder([FromQuery] GetMyOrderQuery rq)
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
        [HttpPost("InitRequestPayment")]
        public async Task<IActionResult> InitRequestPayment([FromQuery] CreateCommand rq)
        {
            return Ok(await Mediator.Send(rq));
        }

        [HttpGet("UpdateStatusOrder")]
        public async Task<IActionResult> UpdateStatusOrder([FromQuery] UpdateStatusCommand rq)
        {
            return Ok(await Mediator.Send(rq));
        }
        #endregion
    }
}
