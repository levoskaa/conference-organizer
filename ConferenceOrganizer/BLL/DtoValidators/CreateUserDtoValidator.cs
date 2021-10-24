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
                .NotEmpty().WithMessage("Password is required.")
                .MinimumLength(6).WithMessage("Password must contain at least 6 characters.")
                .Matches(@"[a-z]+").WithMessage("Password must contain at least one lowercase character.")
                .Matches(@"[0-9]+").WithMessage("Password must contain at least one digit."); ;
        }
    }
}