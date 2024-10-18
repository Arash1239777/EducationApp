using EducationalApi.Application.Users.BaseContracts;
using EducationalApi.Domain.Enums;

namespace EducationalApi.Application.Users.Collegians.Commands.InsertCollegian.Contracts
{
    public record InsertCollegianRequestContract:BaseUserContract
    {
        #region Numbers

        /// <summary>
        /// معدل دانشجو.
        /// </summary>
        public double GPA { get; set; }
        #endregion

        #region Strings

        /// <summary>
        /// شماره‌ی‌ دانشجویی.
        /// </summary>
        public string RoleNumber { get; set; }

        /// <summary>
        /// رشته‌ی‌ تحصیلی دانشجو.
        /// </summary>
        public string Major { get; set; }

        /// <summary>
        /// سال تحصیلی دانشجو.
        /// </summary>
        public string AcademicYear { get; set; }

        #endregion

        #region Enums

        /// <summary>
        /// وضعیت فعلی دانشجو.
        /// </summary>
        public EnCollegianStatus Status { get; set; }

        #endregion
    }
}
