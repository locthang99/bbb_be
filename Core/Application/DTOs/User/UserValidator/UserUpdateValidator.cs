using FluentValidation;
using Application.DTOs.User.UserRequest;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.User.UserValidator
{
    public class UserUpdateValidator : AbstractValidator<UserUpdateRequest>
    {
        public UserUpdateValidator()
        {
            RuleFor(x => x.FirstName)
                .MaximumLength(200).WithMessage("Max name 200 characters");
            RuleFor(x => x.LastName)
                .MaximumLength(200).WithMessage("Max name 200 characters");
            //RuleFor(x => x.Dob).GreaterThan(DateTime.Now.AddYears(-100)).WithMessage("Are you 100?");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email is not empty");
        }
    }
}
