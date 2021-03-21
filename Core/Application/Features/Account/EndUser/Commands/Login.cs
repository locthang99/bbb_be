using Application.DTOs.User;
using Application.DTOs.User.UserRequest;
using Application.Enum;
using Application.Exceptions;
using Application.Features.Account.Base.Queries;
using Application.Wrappers;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Transactions;
using ThirdPartyServices.Storage;

namespace Application.Features.Account.EndUser.Commands
{
    public class LoginCommand : UserLoginRequest, IRequest<CommandResponse<TokenResponse>>
    {
    }
    public class LoginCommandHandler : IRequestHandler<LoginCommand, CommandResponse<TokenResponse>>
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IToken _token;
        public LoginCommandHandler(UserManager<User> userManager, SignInManager<User> signInManager, IToken token)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _token = token;
        }
        public async Task<CommandResponse<TokenResponse>> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByNameAsync(request.Username);
            if (user == null)
                throw new AuthFailedException("Username is not exist");
            var result = await _signInManager.PasswordSignInAsync(user, request.Password, request.RememberMe, false);
            if (!result.Succeeded)
                throw new AuthFailedException("Username or password is invalid");
            var token = new TokenResponse()
            {
                UserId = user.Id.ToString(),
                Username = user.UserName,
                Token = await _token.GenerateToken(user)
            };
            return new CommandOK<TokenResponse>()
            {
                Msg = "Login OK",
                Data = token
            };
        }
    }
}
