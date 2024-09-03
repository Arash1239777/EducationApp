﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EducationalApi.Domain.Entities.Aggrigators.Users.Masters;
using FluentValidation;

namespace EducationalApi.Domain.Entities.Validators.Users.MasterValidator
{
    public class MasterValidator:AbstractValidator<Masters>
    {
        public MasterValidator()
        {
            RuleFor(masters => masters.Email)
                .NotEmpty().WithMessage("email_can_not_be_empty")
                .NotNull().WithMessage("email_can_not_be_null")
                .MaximumLength(30).WithMessage("email_length_can_not_bigger_than_30_character")
                .MinimumLength(10).WithMessage("email_length_can_not_less_than_10_character")
                .Matches("@\"^([\\w-\\.]+)@((\\[[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([\\w-]+\\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\\]?)$\"")
                .WithMessage("email_has_bad_experition");

            RuleFor(masters => masters.Name)
                .NotEmpty().WithMessage("name_can_not_be_empty")
                .NotNull().WithMessage("name_can_not_be_null")
                .MaximumLength(50).WithMessage("name_length_can_not_bigger_than_50_character")
                .MinimumLength(3).WithMessage("name_length_can_not_less_than_3_character");

            RuleFor(masters => masters.LastName)
                .NotEmpty().WithMessage("last_name_can_not_be_empty")
                .NotNull().WithMessage("last_name_can_not_be_null")
                .MaximumLength(50).WithMessage("last_name_length_can_not_bigger_than_50_character")
                .MinimumLength(3).WithMessage("last_name_length_can_not_less_than_3_character");

            RuleFor(masters => masters.PhoneNumber)
                .NotEmpty().WithMessage("phone_number_can_not_be_empty")
                .NotNull().WithMessage("phone_number_can_not_be_null")
                .MaximumLength(11).WithMessage("phone_number_length_can_not_bigger_than_11_character")
                .MinimumLength(11).WithMessage("phone_number_length_can_not_less_than_11_character");

            RuleFor(masters => masters.master_id)
                .GreaterThan(0)
                .WithMessage("Error_MasterId_Greater_Than_Zero");


            RuleFor(masters => masters.department)
                .NotEmpty()
                .WithMessage("Error_Department_Not_Empty")
                .MaximumLength(100)
                .WithMessage("Error_Department_Max_Length_100");


            RuleFor(masters => masters.title)
                .NotEmpty()
                .WithMessage("Error_Title_Not_Empty")
                .MaximumLength(50)
                .WithMessage("Error_Title_Max_Length_50");


            RuleFor(masters => masters.specialization)
                .NotEmpty()
                .WithMessage("Error_Specialization_Not_Empty")
                .MaximumLength(100)
                .WithMessage("Error_Specialization_Max_Length_100");


            RuleFor(masters => masters.Hire_date)
                .LessThanOrEqualTo(DateTime.Now)
                .WithMessage("Error_HireDate_In_The_Past_Or_Today");


            RuleFor(masters => masters.salary)
                .GreaterThanOrEqualTo(0)
                .WithMessage("Error_Salary_Greater_Than_Or_Equal_Zero");

            
            RuleFor(masters => masters.Status)
                .IsInEnum()
                .WithMessage("Error_Status_Invalid_Enum_Value");
        }
    }
}