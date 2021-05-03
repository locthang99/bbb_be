using Application.Features.Account.EndUser.Commands;
using Application.Features.Account.EndUser.Queries;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendAPI.Controllers.v1
{
    [ApiVersion("1.0")]
    [ApiController]
    public class EndUserController: BaseApiController
    {
        [HttpPost("Resgister")]
        public async Task<IActionResult> Register([FromForm] RegisterCommand rq)
        {
            return Ok(await Mediator.Send(rq));
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] LoginCommand rq)
        {
            return Ok(await Mediator.Send(rq));
        }

        [HttpPost("LoginWithFacebook")]
        public async Task<IActionResult> LoginFacebook([FromQuery] string Token)
        {
            var rq = new LoginFBCommand { Token = Token };
            return Ok(await Mediator.Send(rq));
        }

        [HttpGet("GetProfile")]
        public async Task<IActionResult> GetProfile()
        {
            var rq = new GetProfileQuery();
            return Ok(await Mediator.Send(rq));
        }

        [HttpGet("GetSubscriber")]
        public async Task<IActionResult> GetObserver([FromQuery] GetSubscriberQuery rq)
        {
            return Ok(await Mediator.Send(rq));
        }

        [HttpGet("GetPublisher")]
        public async Task<IActionResult> GetPublicer([FromQuery] GetPublisherQuery rq)
        {
            return Ok(await Mediator.Send(rq));
        }
    }
}
