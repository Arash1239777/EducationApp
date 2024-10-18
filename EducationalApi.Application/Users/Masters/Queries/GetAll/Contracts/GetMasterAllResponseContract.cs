using EducationalApi.Domain.Enums;

namespace EducationalApi.Application.Users.Masters.Queries.GetAll.Contracts
{
    public record GetMasterAllResponseContract
    {
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
    }
}
