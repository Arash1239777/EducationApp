using Domain.Entities.Aggrigators.Users.Collegians;
using FluentValidation;

namespace EducationalApi.Domain.Entities.Validators.Users.CollegianValidator
{
    public class CollegianValidator : AbstractValidator<Collegian>
    {
        public CollegianValidator()
        {
            RuleFor(collegian => collegian.Email)
                .NotEmpty().WithMessage("email_can_not_be_empty")
                .NotNull().WithMessage("email_can_not_be_null")
                .MinimumLength(10).WithMessage("email_length_can_not_less_than_10_character")
                .Matches(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$")
                .WithMessage("email_has_bad_experition");

            RuleFor(collegian => collegian.Name)
                .NotEmpty().WithMessage("name_can_not_be_empty")
                .NotNull().WithMessage("name_can_not_be_null")
                .MaximumLength(50).WithMessage("name_length_can_not_bigger_than_50_character")
                .MinimumLength(3).WithMessage("name_length_can_not_less_than_3_character");

            RuleFor(collegian => collegian.LastName)
                .NotEmpty().WithMessage("last_name_can_not_be_empty")
                .NotNull().WithMessage("last_name_can_not_be_null")
                .MaximumLength(50).WithMessage("last_name_length_can_not_bigger_than_50_character")
                .MinimumLength(3).WithMessage("last_name_length_can_not_less_than_3_character");

            RuleFor(collegian => collegian.PhoneNumber)
                .NotEmpty().WithMessage("phone_number_can_not_be_empty")
                .NotNull().WithMessage("phone_number_can_not_be_null")
                .MaximumLength(11).WithMessage("phone_number_length_can_not_bigger_than_11_character")
                .MinimumLength(11).WithMessage("phone_number_length_can_not_less_than_11_character");


            RuleFor(x => x.GPA)
                .InclusiveBetween(0, 20)
                .WithMessage("Error_GPA_Between_0_and_20");

            RuleFor(x => x.RoleNumber)
                .NotEmpty()
                .WithMessage("Error_RoleNumber_Not_Empty")
                .MaximumLength(20)
                .WithMessage("Error_RoleNumber_Max_Length_20");

            RuleFor(x => x.Major)
                .NotEmpty()
                .WithMessage("Error_Major_Not_Empty")
                .MaximumLength(100)
                .WithMessage("Error_Major_Max_Length_100");

            RuleFor(x => x.EnrollmentDate)
                .LessThanOrEqualTo(DateTime.Now)
                .WithMessage("Error_EnrollmentDate_In_The_Past_Or_Today");

            RuleFor(x => x.Status)
                .IsInEnum()
                .WithMessage("Error_Status_Invalid_Enum_Value");

        }
    }
}
