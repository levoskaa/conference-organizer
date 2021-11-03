using BLL.Dtos;
using FluentValidation;

namespace BLL.DtoValidators
{
    public class ConferenceUpsertDtoValidator : AbstractValidator<ConferenceUpsertDto>
    {
        public ConferenceUpsertDtoValidator()
        {
            RuleFor(ent => ent.Name)
                .NotEmpty().WithMessage("Name is required");
            RuleFor(ent => ent.BeginDate)
                .NotEmpty().WithMessage("Begin date is required.");
            RuleFor(ent => ent.EndDate)
                .NotEmpty().WithMessage("End date is required.")
                .GreaterThanOrEqualTo(ent => ent.BeginDate).WithMessage("End date must be after begin date.");
        }
    }
}