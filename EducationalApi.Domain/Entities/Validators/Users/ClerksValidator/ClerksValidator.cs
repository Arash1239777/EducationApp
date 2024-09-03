using Domain.Entities.Aggrigators.Users.Clerks;
using FluentValidation;

namespace Domain.Entities.Validators.Users.ClerksValidator;
public class ClerksValidator : AbstractValidator<Clerks>
{
    public ClerksValidator()
    {
        RuleFor(clerk => clerk.Email)
            .NotEmpty().WithMessage("email_can_not_be_empty")
            .NotNull().WithMessage("email_can_not_be_null")
            .MaximumLength(30).WithMessage("email_length_can_not_bigger_than_30_character")
            .MinimumLength(10).WithMessage("email_length_can_not_less_than_10_character")
            .Matches("@\"^([\\w-\\.]+)@((\\[[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([\\w-]+\\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\\]?)$\"")
            .WithMessage("email_has_bad_experition");

        RuleFor(clerck => clerck.Name)
            .NotEmpty().WithMessage("name_can_not_be_empty")
            .NotNull().WithMessage("name_can_not_be_null")
            .MaximumLength(50).WithMessage("name_length_can_not_bigger_than_50_character")
            .MinimumLength(3).WithMessage("name_length_can_not_less_than_3_character");
        
        RuleFor(clerck => clerck.LastName)
            .NotEmpty().WithMessage("last_name_can_not_be_empty")
            .NotNull().WithMessage("last_name_can_not_be_null")
            .MaximumLength(50).WithMessage("last_name_length_can_not_bigger_than_50_character")
            .MinimumLength(3).WithMessage("last_name_length_can_not_less_than_3_character");
        
        RuleFor(clerck => clerck.PhoneNumber)
            .NotEmpty().WithMessage("phone_number_can_not_be_empty")
            .NotNull().WithMessage("phone_number_can_not_be_null")
            .MaximumLength(11).WithMessage("phone_number_length_can_not_bigger_than_11_character")
            .MinimumLength(11).WithMessage("phone_number_length_can_not_less_than_11_character");

        RuleFor(clerck => clerck.UserCode)
            .LessThan(400000000).WithMessage("user_code_can_not_be_less_than_400000000")
            .GreaterThan(500000000).WithMessage("user_code_can_not_be_bigger_than_500000000");

        RuleFor(clerck => clerck.Position)
            .IsInEnum().WithMessage("position_not_valid");
    }
}
