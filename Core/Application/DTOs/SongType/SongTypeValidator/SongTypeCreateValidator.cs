using FluentValidation;
using Application.DTOs.SongType.SongTypeRequest;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.SongType.SongTypeValidator
{
    public class SongTypeCreateValidator : AbstractValidator<SongTypeCreateRequest>
    {
        public SongTypeCreateValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name is not emty");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Description is not emty").MinimumLength(10).WithMessage("Description minimum 10 characters!");
        }
    }
}
