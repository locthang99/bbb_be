using FluentValidation;
using Application.DTOs.User.UserRequest;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.User.UserValidator
{
    public class UserLoginValidator: AbstractValidator<UserLoginRequest>
    {
        public UserLoginValidator()
        {
            RuleFor(x => x.Username).NotEmpty().WithMessage("Username not empty");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password not empty").MinimumLength(6).WithMessage("Password must > 6");
        }
    }
}
