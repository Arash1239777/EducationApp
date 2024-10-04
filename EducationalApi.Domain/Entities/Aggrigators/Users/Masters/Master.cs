using EducationalApi.Domain.Entities.Exceptions.Users.Clerck;
using EducationalApi.Domain.Entities.Validators.Users.MasterValidator;
using EducationalApi.Domain.Enums;
using FluentValidation.Results;

namespace Domain.Entities.Aggrigators.Users.Master
{
    /// <summary>
    /// نمایانگر اطلاعات استاد در سیستم آموزشی.
    /// </summary>
    public class Master : BaseInfo
    {
        private Master() { }

        #region Props

        #region Numbers

        /// <summary>
        /// شناسه‌ی‌ استاد.
        /// </summary>
        public long MasterId { get; protected set; }

        #endregion

        #region Strings

        /// <summary>
        /// بخش مربوط به استاد.
        /// </summary>
        public string Department { get; protected set; }

        /// <summary>
        /// عنوان علمی استاد.
        /// </summary>
        public string Title { get; protected set; }

        /// <summary>
        /// تخصص استاد.
        /// </summary>
        public EnSpecialization Specialization { get; protected set; }

        #endregion

        #region DateTimes

        /// <summary>
        /// تاریخ استخدام.
        /// </summary>
        public DateTime HireDate { get; protected set; }

        #endregion

        #region Numbers

        /// <summary>
        /// حقوق استاد.
        /// </summary>
        public double Salary { get; protected set; }

        #endregion

        #region Enums

        /// <summary>
        /// وضعیت استاد.
        /// </summary>
        public EnMasterStatus Status { get; protected set; }

        #endregion

        #endregion

        public void Update(
            string title,
            EnSpecialization specialization,
            DateTime hireDate,
            double salary,
            EnMasterStatus status)
        {
            Title = title;
            Specialization = specialization;
            HireDate = hireDate;
            Salary = salary;
            Status = status;
        }

        public static async Task<Master> Factory(
            string name,
            string lastName,
            string phoneNumber,
            DateTime birthdate,
            string nationalCode,
            bool gender,
            short nationalty,
            string email,
            string department,
            string title,
            EnSpecialization specialization,
            DateTime hireDate,
            double salary,
            EnMasterStatus status)
        {
            MasterValidator validator = new();

            Master master = new()
            {
                Name = name,
                LastName = lastName,
                PhoneNumber = phoneNumber,
                Birthdate = birthdate,
                NationalCode = nationalCode,
                Gender = gender,
                Nationalty = nationalty,
                Email = email,
                Department = department,
                Title = title,
                Specialization = specialization,
                HireDate = hireDate,
                Salary = salary,
                Status = status
            };

            ValidationResult validationResult = await validator.ValidateAsync(master);

            if (!validationResult.IsValid)
            {
                ClercksExeptions exception = new("Errors happened when creating master.");

                validationResult.Errors.ForEach(error => exception.Errors.Add(error.ErrorMessage));

                throw exception;
            }

            return master;
        }
    }
}
