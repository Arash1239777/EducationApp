using System;
using Domain.Entities.Aggrigators.Users;
using EducationalApi.Domain.Entities.Aggrigators.Users.Collegian;
using EducationalApi.Domain.Entities.Exceptions.Users.Clerck;
using EducationalApi.Domain.Entities.Validators.Users.MasterValidator;
using EducationalApi.Domain.Enums;
using FluentValidation.Results;

namespace EducationalApi.Domain.Entities.Aggrigators.Users.Masters
{
    /// <summary>
    /// نمایانگر اطلاعات اساتید در سیستم آموزشی.
    /// </summary>
    public class Masters : BaseInfo
    {
        private Masters() { }

        #region props

        #region Numbers

        /// <summary>
        /// شناسه‌ی استاد.
        /// </summary>
        public long master_id { get; protected set; }

        #endregion

        #region Strings

        /// <summary>
        /// بخش مربوط به استاد.
        /// </summary>
        public string department { get; protected set; }

        /// <summary>
        /// عنوان علمی استاد.
        /// </summary>
        public string title { get; protected set; }

        /// <summary>
        /// تخصص استاد.
        /// </summary>
        public EnSpecialization specialization { get; protected set; }

        #endregion

        #region DateTimes

        /// <summary>
        /// تاریخ استخدام.
        /// </summary>
        public DateTime Hire_date { get; protected set; }

        #endregion

        #region Numbers

        /// <summary>
        /// حقوق استاد.
        /// </summary>
        public double salary { get; protected set; }

        #endregion

        #region Enums

        /// <summary>
        /// وضعیت استاد.
        /// </summary>
        public EnMasterStatus Status { get; protected set; }

        #endregion

        #endregion

        public static async Task<Masters> Factory(
            string name,
            string lastName,
            string phoneNumber,
            DateTime birthdate,
            string nationalCode,
            bool gender,
            short nationalty,
            string email,
            long master_id,
            string department,
            string title,
            EnSpecialization specialization,
            DateTime Hire_date,
            double salary,
            EnMasterStatus Status
            )
        {
            MasterValidator validator = new();

            Masters master = new()
            {
                Name = name,
                LastName = lastName,
                PhoneNumber = phoneNumber,
                Birthdate = birthdate,
                NationalCode = nationalCode,
                Gender = gender,
                Nationalty = nationalty,
                Email = email,
                master_id = master_id,
                department = department,
                title = title,
                specialization = specialization,
                Hire_date = Hire_date,
                salary = salary,
                Status = Status
            };

            ValidationResult validationResult = await validator.ValidateAsync(master);

            if (!validationResult.IsValid)
            {
                ClercksExeptions exeption = new("errors happend when creating master.");

                validationResult.Errors.ForEach(error => exeption.Errors.Add(error.ErrorMessage));

                throw exeption;
            }


            return master;

        }
    }
}