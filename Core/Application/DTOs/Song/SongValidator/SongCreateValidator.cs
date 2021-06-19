using FluentValidation;
using Application.DTOs.Song.SongRequest;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.Song.SongValidator
{
    public class SongCreateValidator: AbstractValidator<SongCreateRequest>
    {
        public SongCreateValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name not empty").MaximumLength(200).WithMessage("Max name 200");
            //RuleFor(x => x.Description).NotEmpty().WithMessage("Description not empty").MaximumLength(200).WithMessage("Max name 200");
            //RuleFor(x => x.Duration).NotEmpty().WithMessage("Duration not empty");
            //RuleFor(x => x.TotalCmt).NotEmpty().WithMessage("Total Comment not empty");
            //RuleFor(x => x.TotalLike).NotEmpty().WithMessage("Total Like not empty");
            //RuleFor(x => x.TotalListen).NotEmpty().WithMessage("Total Listen not empty");
            //RuleFor(x => x.Thumbnail).NotEmpty().WithMessage("Thumbnail is not empty");
            RuleFor(x => x.FileMusic128).NotEmpty().WithMessage("File Audio 128 is not empty");


        }
    }
}
