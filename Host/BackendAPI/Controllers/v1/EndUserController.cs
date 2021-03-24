using Application.Features.Account.Base.Queries;
using Application.Features.Account.EndUser.Commands;
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

        
        [HttpPost("GetProfile")]
        public async Task<IActionResult> GetProfile()
        {
            var rq = new GetProfileCommand();
            return Ok(await Mediator.Send(rq));
        }
    }
}
