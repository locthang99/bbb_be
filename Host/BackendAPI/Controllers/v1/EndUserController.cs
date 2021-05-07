using Application.Features.Account.Base.Commands;
using Application.Features.Account.EndUser.Commands;
using Application.Features.Account.EndUser.Queries;
using BackendAPI.ValidateFilter;
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
    public class EndUserController: BaseApiController
    {
        #region Queries

        [HttpGet("GetProfile")]
        public async Task<IActionResult> GetProfile()
        {
            var rq = new GetProfileQuery();
            return Ok(await Mediator.Send(rq));
        }

        [HttpGet("GetSubscriber")]
        public async Task<IActionResult> GetSubscriber([FromQuery] GetSubscriberQuery rq)
        {
            return Ok(await Mediator.Send(rq));
        }

        [HttpGet("GetPublisher")]
        public async Task<IActionResult> GetPublisher([FromQuery] GetPublisherQuery rq)
        {
            return Ok(await Mediator.Send(rq));
        }

        [HttpGet("GetRecommendPublisher")]
        public async Task<IActionResult> GetPublicer([FromQuery] GetRecommendPublicerQuery rq)
        {
            return Ok(await Mediator.Send(rq));
        }

        #endregion

        #region Command
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

        [HttpPut("Follow")]
        public async Task<IActionResult> Follow([FromQuery] FollowUserCommand rq)
        {
            return Ok(await Mediator.Send(rq));
        }

        [HttpPut("UnFollow")]
        public async Task<IActionResult> UnFollow([FromQuery] UnFollowUserCommand rq)
        {
            return Ok(await Mediator.Send(rq));
        }
        #endregion
    }
}
