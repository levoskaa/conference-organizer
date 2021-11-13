using BLL.Dtos;
using FluentValidation;

namespace BLL.DtoValidators
{
    public class ProfessionalFieldUpsertDtoValidator : AbstractValidator<ProfessionalFieldUpsertDto>
    {
        public ProfessionalFieldUpsertDtoValidator()
        {
            RuleFor(ent => ent.Name)
                .NotEmpty().WithMessage("Name is required.");
        }
    }
}