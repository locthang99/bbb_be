using Application.Features.Account.Base.Commands;
using Application.Features.Account.Base.Queries;
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

        [HttpGet("GetUserById")]
        [AllowAnonymous]
        public async Task<IActionResult> GetUserById([FromQuery] GetUserByIdQuery rq)
        {
            return Ok(await Mediator.Send(rq));
        }

        [HttpGet("GetUserByKeyword")]
        [AllowAnonymous]
        public async Task<IActionResult> GetUserByKeyword([FromQuery] GetUserByKeywordQuery rq)
        {
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
        [AllowAnonymous]
        public async Task<IActionResult> GetPublicer([FromQuery] GetRecommendPublicerQuery rq)
        {
            return Ok(await Mediator.Send(rq));
        }


        #endregion

        #region Command
        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromForm] RegisterCommand rq)
        {
            return Ok(await Mediator.Send(rq));
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] LoginCommand rq)
        {
            return Ok(await Mediator.Send(rq));
        }

        [HttpPut("UpdateProfile")]
        public async Task<IActionResult> UpdateProfile([FromForm] UpdateProfileCommand rq)
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

        [HttpPost("SendLinkVerifyEmail")]
        [AllowAnonymous]
        public async Task<IActionResult> SendLinkVerifyEmail([FromBody] SendVerifyEmailCommand rq)
        {
            return Ok(await Mediator.Send(rq));
        }

        [HttpGet("VerifyEmail")]
        [AllowAnonymous]
        public async Task<IActionResult> VerifyEmail([FromQuery] VerifyEmailCommand rq)
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
