﻿using Domain.Entities.Validators.Users.ClerksValidator;
using Domain.Enums;
using EducationalApi.Domain.Entities.Exceptions.Users.Clerck;
using FluentValidation.Results;
using System.Text;

namespace Domain.Entities.Aggrigators.Users.Clerk;
public class Clerks : BaseInfo
{
    private Clerks() { }

    #region props
    #region enums
    /// <summary>
    /// سمت شغلی
    /// </summary>
    public EnPosition Position { get; private set; }
    #endregion
    #region numbers
    /// <summary>
    /// شناسه کارمندی
    /// </summary>
    public long UserCode { get; private set; }
    #endregion
    #endregion

    public static ValueTask<Clerks> Factory(
        string name,
        string lastName,
        string phoneNumber,
        DateTime birthdate,
        string nationalCode,
        bool gender,
        short nationalty,
        EnPosition position,
        string email,
        long userCode
        )
    {
        StringBuilder sb = new();
        sb.Append(name);
        sb.Append(' ');
        sb.Append(lastName);

        ClerksValidator validator = new();

        Clerks clerck = new()
        {
            Name = name,
            LastName = lastName,
            PhoneNumber = phoneNumber,
            Birthdate = birthdate,
            FullName = sb.ToString(),
            NationalCode = nationalCode,
            Gender = gender,
            Nationalty = nationalty,
            Position = position,
            Email = email,
            UserCode = userCode
        };

        ValidationResult validationResult = validator.Validate(clerck);

        if (!validationResult.IsValid)
        {
            ClercksExeptions exeption = new("errors happend when creating clerck.");

            validationResult.Errors.ForEach(error => exeption.Errors.Add(error.ErrorMessage));

            throw exeption;
        }

        return ValueTask.FromResult(clerck);
    }
}
