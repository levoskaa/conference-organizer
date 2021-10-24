using BLL.Dtos;
using FluentValidation;

namespace BLL.DtoValidators
{
    public class CreateUserDtoValidator : AbstractValidator<CreateUserDto>
    {
        public CreateUserDtoValidator()
        {
            RuleFor(ent => ent.Username)
                .NotEmpty().WithMessage("Username is required.");
            RuleFor(ent => ent.Password)
                .NotEmpty().WithMessage("Password is required.");
        }
    }
}