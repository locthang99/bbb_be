using FluentValidation;
using Application.DTOs.PlayList.PlayListRequest;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.PlayList.PlayListValidator
{
    public class PlayListCreateValidator : AbstractValidator<PlayListCreateRequest>
    {
        public PlayListCreateValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name not empty").MaximumLength(200).WithMessage("Max name 200");
            RuleFor(x => x.Description).MaximumLength(200).WithMessage("Max name 200");
            // RuleFor(x => x.Thumbnail).NotEmpty().WithMessage("Thumbnail is not empty");
        }
    }
}
