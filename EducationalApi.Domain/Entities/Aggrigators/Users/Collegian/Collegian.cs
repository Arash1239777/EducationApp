using System;
using Domain.Entities.Aggrigators.Users;
using EducationalApi.Domain.Enums;

namespace EducationalApi.Domain.Entities.Aggrigators.Users.Collegian
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
        /// شناسه‌ی منحصر به فرد دانشجو.
        /// </summary>
        public long collegian_id { get; protected set; }

        /// <summary>
        /// معدل دانشجو.
        /// </summary>
        public double GPA { get; protected set; }

        #endregion

        #region Strings

        /// <summary>
        /// شماره دانشجویی.
        /// </summary>
        public string RoleNumber { get; protected set; }

        /// <summary>
        /// رشته تحصیلی دانشجو.
        /// </summary>
        public string major { get; protected set; }

        /// <summary>
        /// سال تحصیلی دانشجو.
        /// </summary>
        public string academic_year { get; protected set; }

        #endregion

        #region Datetimes

        /// <summary>
        /// تاریخ ثبت‌نام دانشجو.
        /// </summary>
        public DateTime enrollment_date { get; protected set; }

        #endregion

        #region Enums

        /// <summary>
        /// وضعیت فعلی دانشجو.
        /// </summary>
        public EnCollegianStatus Status { get; protected set; }

        #endregion

        #endregion

        public static Collegian Factory(
            string name,
            string lastName,
            string phoneNumber,
            DateTime birthdate,
            string nationalCode,
            bool gender,
            short nationalty,
            string email,
            long collegian_id,
            double GPA,
            string RoleNumber,
            string major,
            string academic_year,
            string ContactNumber,
            DateTime enrollment_date,
            EnCollegianStatus Status)
        {
            return new Collegian()
            {
                Name = name,
                LastName = lastName,
                PhoneNumber = phoneNumber,
                Birthdate = birthdate,
                NationalCode = nationalCode,
                Gender = gender,
                Nationalty = nationalty,
                Email = email,
                collegian_id = collegian_id,
                GPA = GPA,
                RoleNumber = RoleNumber,
                major = major,
                academic_year = academic_year,
                enrollment_date = enrollment_date,
                Status = Status
            };
        }
    }
}
