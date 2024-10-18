using EducationalApi.Domain.Enums;

namespace EducationalApi.Application.Users.Collegian.Queries.GetAll.Contracts
{
    public record GetAllCollegianResponseContract
    {
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

    }
}
