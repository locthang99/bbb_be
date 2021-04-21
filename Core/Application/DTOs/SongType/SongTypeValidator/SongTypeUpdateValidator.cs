using FluentValidation;
using Application.DTOs.Type.TypeRequest;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.Type.TypeValidator
{
    public class TypeUpdateValidator: AbstractValidator<TypeUpdateRequest>
    {
        public TypeUpdateValidator()
        {
            //RuleFor(x => x.Id).NotEmpty().WithMessage("Id is not emty");
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name is not emty");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Description is not emty").MinimumLength(10).WithMessage("Description minimum 10 characters!");
        }
    }
}
