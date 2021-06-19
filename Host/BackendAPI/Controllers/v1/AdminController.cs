using Application.Features.Account.Base.Commands;
using Application.Features.Account.Admin.Commands;
using Application.Features.Account.Admin.Queries;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendAPI.Controllers.v1
{
    [ApiVersion("1.0")]
    [ApiController]
    public class AdminController: BaseApiController
    {
        #region Query
        [HttpGet("ById")]
        public async Task<IActionResult> GetAccountById([FromQuery] GetAccountByIdQuery rq)
        {
            return Ok(await Mediator.Send(rq));
        }

        [HttpGet("GetAllAccount")]
        public async Task<IActionResult> GetAllAccount([FromQuery] GetAccountQuery rq)
        {
            return Ok(await Mediator.Send(rq));
        }

        [HttpGet("ListDeleted")]
        public async Task<IActionResult> GetListDeleted([FromQuery] GetListDeletedQuery rq)
        {
            return Ok(await Mediator.Send(rq));
        }
        #endregion
        #region Command
        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] LoginCommand rq)
        {
            return Ok(await Mediator.Send(rq));
        }

        [HttpPost("ChangePassword")]
        public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordCommand rq)
        {
            return Ok(await Mediator.Send(rq));
        }

        [HttpPost("SendCodeResetPassword")]
        [AllowAnonymous]
        public async Task<IActionResult> SendCodeResetPassword([FromBody] SendCodeResetPasswordCommand rq)
        {
            return Ok(await Mediator.Send(rq));
        }

        [HttpPost("ResetPassword")]
        [AllowAnonymous]
        public async Task<IActionResult> ResetPassword([FromBody] ResetPasswordCommand rq)
        {
            return Ok(await Mediator.Send(rq));
        }

        [HttpDelete]
        [Authorize(Roles = "SUPPERADMIN,ADMIN")]
        public async Task<IActionResult> Delete([FromQuery] int Id)
        {
            var rq = new DeleteCommand();
            rq.SetId(Id);
            return Ok(await Mediator.Send(rq));
        }

        [HttpPut("UnDelete")]
        [Authorize(Roles = "SUPPERADMIN,ADMIN")]
        public async Task<IActionResult> UnDelete([FromQuery] int Id)
        {
            var rq = new UnDeleteCommand();
            rq.SetId(Id);
            return Ok(await Mediator.Send(rq));
        }

        [HttpDelete("StrongDelete")]
        [Authorize(Roles = "SUPPERADMIN,ADMIN")]
        public async Task<IActionResult> StrongDelete([FromQuery] int Id)
        {
            var rq = new StrongDeleteCommand();
            rq.SetId(Id);
            return Ok(await Mediator.Send(rq));
        }
        #endregion
    }
}
