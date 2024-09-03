using System;
using Domain.Entities.Aggrigators.Users;
using EducationalApi.Domain.Enums;

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
        public string specialization { get; protected set; }

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
    }
}