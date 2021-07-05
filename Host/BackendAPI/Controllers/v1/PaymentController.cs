using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Application.Wrappers;
using ThirdPartyServices.Payment;
using ThirdPartyServices.Payment.DTO;
//using Application.Features.Tag.Commands;

namespace BackendAPI.Controllers.v1
{
    [ApiVersion("1.0")]
    public class PaymentController : BaseApiController
    {
        #region Queries
        private readonly IMomoService _momoService;
        public PaymentController(IMomoService momoService)
        {
            _momoService = momoService;
        }


        [HttpPost("InitRequestMomo")]
        public async Task<IActionResult> InitRequestMomo([FromBody]  InitRequest rq)
        {
            var rs = await _momoService.InitPayment(rq);
            return Ok(new Response<object>() { Msg = "Init OK", Data = rs });
        }


        #endregion
    }
    }
