using FluentValidation;
using Application.DTOs.Song.SongRequest;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.Song.SongValidator
{
    public class SongUpdateValidator : AbstractValidator<SongUpdateRequest>
    {
        public SongUpdateValidator()
        {
            //RuleFor(x => x.Id).NotEmpty().WithMessage("Id not empty");
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name not empty").MaximumLength(200).WithMessage("Max name 200");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Description not empty").MaximumLength(200).WithMessage("Max name 200");
            //RuleFor(x => x.Duration).NotEmpty().WithMessage("Duration not empty");
        }
    }
}
