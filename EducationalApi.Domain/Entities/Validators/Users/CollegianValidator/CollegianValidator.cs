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
                .MaximumLength(30).WithMessage("email_length_can_not_bigger_than_30_character")
                .MinimumLength(10).WithMessage("email_length_can_not_less_than_10_character")
                .Matches("@\"^([\\w-\\.]+)@((\\[[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([\\w-]+\\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\\]?)$\"")
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

            RuleFor(x => x.CollegianId)
                .GreaterThan(0)
                .WithMessage("Error_Id_Greater_Than_Zero");


            RuleFor(x => x.GPA)
                .InclusiveBetween(0, 4)
                .WithMessage("Error_GPA_Between_0_and_4");

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

            RuleFor(x => x.AcademicYear)
                .NotEmpty()
                .WithMessage("Error_AcademicYear_Not_Empty")
                .Matches(@"^\d{4}/\d{4}$")
                .WithMessage("Error_AcademicYear_Format_yyyy/yyyy");

            RuleFor(x => x.EnrollmentDate)
                .LessThanOrEqualTo(DateTime.Now)
                .WithMessage("Error_EnrollmentDate_In_The_Past_Or_Today");

            RuleFor(x => x.Status)
                .IsInEnum()
                .WithMessage("Error_Status_Invalid_Enum_Value");

        }
    }
}
