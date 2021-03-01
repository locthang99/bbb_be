using FluentValidation;
using Application.DTOs.PlayList.PlayListRequest;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.PlayList.PlayListValidator
{

    public class PlayListUpdateValidator : AbstractValidator<PlayListUpdateRequest>
    {
        public PlayListUpdateValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name not empty").MaximumLength(200).WithMessage("Max name 200");
            RuleFor(x => x.Description).MaximumLength(200).WithMessage("Max name 200");

        }
    }
}

