using BLL.Dtos;
using FluentValidation;

namespace BLL.DtoValidators
{
    public class RoomUpsertDtoValidator : AbstractValidator<RoomUpsertDto>
    {
        public RoomUpsertDtoValidator()
        {
            RuleFor(ent => ent.UniqueName)
                .NotEmpty().WithMessage("Name is required.");
            RuleFor(ent => ent.Capacity)
                .NotEmpty().WithMessage("Capacity is required.");
        }
    }
}