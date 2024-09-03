namespace Domain.Entities.Aggrigators.Users;
public class BaseInfo
{
    #region numbers
    /// <summary>
    /// شناسه 
    /// </summary>
    public long Id { get; protected set; }
    /// <summary>
    /// کد ملیت
    /// </summary>
    public short Nationalty { get; protected set; }
    #endregion

    #region strings
    /// <summary>
    /// نام
    /// </summary>
    public string Name { get; protected set; } = string.Empty;
    /// <summary>
    /// نام خانوادگی
    /// </summary>
    public string LastName { get; protected set; } = string.Empty;
    /// <summary>
    /// نام کلی
    /// </summary>
    public string FullName { get; protected set; } = string.Empty;
    /// <summary>
    /// شماره تلفن
    /// </summary>
    public string PhoneNumber { get; protected set; } = string.Empty;
    /// <summary>
    /// کدملی
    /// </summary>
    public string NationalCode { get; protected set; } = string.Empty;
    /// <summary>
    /// ایمیل
    /// </summary>
    public string Email { get; protected set; } = string.Empty;
    #endregion

    #region datetimes
    /// <summary>
    /// تاریخ تولد
    /// </summary>
    public DateTime Birthdate { get; protected set; }
    #endregion

    #region booleans
    /// <summary>
    /// جنسیت
    /// </summary>
    public bool Gender { get; protected set; }
    #endregion
}