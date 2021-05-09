using Application.Features.Account.Base.Commands;
using Application.Features.Account.Base.Queries;
using Application.Features.Account.EndUser.Commands;
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
        #region Command
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
        #endregion
    }
}
