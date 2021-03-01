using FluentValidation;
using Application.DTOs.User.UserRequest;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.User.UserValidator
{
    public class UserRegisterValidator : AbstractValidator<UserRegisterRequest>
    {
        public UserRegisterValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("Username not empty")
                .MaximumLength(200).WithMessage("Max name 200 characters");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Username not empty")
                .MaximumLength(200).WithMessage("Max name 200 ");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password not empty")
                .MinimumLength(6).WithMessage("Password must > 6 characters");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Password not empty")
                .MinimumLength(6).WithMessage("Password must > 6 characters");
            //RuleFor(x => x.Dob).GreaterThan(DateTime.Now.AddYears(-100)).WithMessage("Are you 100?");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email is not empty");
            RuleFor(x => x).Custom((rq, context) =>
            {
                if (rq.Password != rq.ConfirmPassword)
                    context.AddFailure("Password!=ConfirmPassword");
            });
            RuleFor(x => x.Thumbnail).NotEmpty().WithMessage("Thumbnail is not empty");
        }
    }
}
