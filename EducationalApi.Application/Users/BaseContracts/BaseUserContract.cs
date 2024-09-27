namespace EducationalApi.Application.Users.BaseContracts;
public record BaseUserContract
{
    #region numbers
    /// <summary>
    /// شناسه 
    /// </summary>
    public long Id { get;  set; }
    /// <summary>
    /// کد ملیت
    /// </summary>
    public short Nationalty { get;  set; }
    #endregion

    #region strings
    /// <summary>
    /// نام
    /// </summary>
    public string Name { get;  set; }
    /// <summary>
    /// نام خانوادگی
    /// </summary>
    public string LastName { get;  set; }
    /// <summary>
    /// نام کلی
    /// </summary>
    public string FullName { get;  set; }
    /// <summary>
    /// شماره تلفن
    /// </summary>
    public string PhoneNumber { get;  set; }
    /// <summary>
    /// کدملی
    /// </summary>
    public string NationalCode { get;  set; }
    /// <summary>
    /// ایمیل
    /// </summary>
    public string Email { get;  set; }
    #endregion

    #region datetimes
    /// <summary>
    /// تاریخ تولد
    /// </summary>
    public DateTime Birthdate { get;  set; }
    #endregion

    #region booleans
    /// <summary>
    /// جنسیت
    /// </summary>
    public bool Gender { get;  set; }
    #endregion
}
