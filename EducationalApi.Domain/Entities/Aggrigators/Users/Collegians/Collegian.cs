using EducationalApi.Domain.Entities.Exceptions.Users.Clerck;
using EducationalApi.Domain.Entities.Validators.Users.CollegianValidator;
using EducationalApi.Domain.Enums;
using FluentValidation.Results;

namespace Domain.Entities.Aggrigators.Users.Collegian
{
    /// <summary>
    /// نمایانگر اطلاعات دانشجو در سیستم آموزشی.
    /// </summary>
    public class Collegian : BaseInfo
    {
        private Collegian() { }

        #region Props

        #region Numbers

        /// <summary>
        /// شناسه‌ی‌ منحصر‌به‌فرد دانشجو.
        /// </summary>
        public long CollegianId { get; protected set; }

        /// <summary>
        /// معدل دانشجو.
        /// </summary>
        public double GPA { get; protected set; }

        #endregion

        #region Strings

        /// <summary>
        /// شماره‌ی‌ دانشجویی.
        /// </summary>
        public string RoleNumber { get; protected set; }

        /// <summary>
        /// رشته‌ی‌ تحصیلی دانشجو.
        /// </summary>
        public string Major { get; protected set; }

        /// <summary>
        /// سال تحصیلی دانشجو.
        /// </summary>
        public string AcademicYear { get; protected set; }

        #endregion

        #region Datetimes

        /// <summary>
        /// تاریخ ثبت‌نام دانشجو.
        /// </summary>
        public DateTime EnrollmentDate { get; protected set; }

        #endregion

        #region Enums

        /// <summary>
        /// وضعیت فعلی دانشجو.
        /// </summary>
        public EnCollegianStatus Status { get; protected set; }

        #endregion

        #endregion

        public static async Task<Collegian> Factory(
            string name,
            string lastName,
            string phoneNumber,
            DateTime birthdate,
            string nationalCode,
            bool gender,
            short nationalty,
            string email,
            long collegianId,
            double GPA,
            string roleNumber,
            string major,
            string academicYear,
            string contactNumber,
            DateTime enrollmentDate,
            EnCollegianStatus status)
        {
            CollegianValidator validator = new();

            Collegian collegian = new()
            {
                Name = name,
                LastName = lastName,
                PhoneNumber = phoneNumber,
                Birthdate = birthdate,
                NationalCode = nationalCode,
                Gender = gender,
                Nationalty = nationalty,
                Email = email,
                CollegianId = collegianId,
                GPA = GPA,
                RoleNumber = roleNumber,
                Major = major,
                AcademicYear = academicYear,
                EnrollmentDate = enrollmentDate,
                Status = status
            };

            ValidationResult validationResult = await validator.ValidateAsync(collegian);

            if (!validationResult.IsValid)
            {
                ClercksExeptions exception = new("Errors happened when creating collegian.");

                validationResult.Errors.ForEach(error => exception.Errors.Add(error.ErrorMessage));

                throw exception;
            }

            return collegian;
        }
    }
}