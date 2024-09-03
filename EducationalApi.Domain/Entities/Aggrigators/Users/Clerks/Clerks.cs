using Domain.Enums;
using System.Text;

namespace Domain.Entities.Aggrigators.Users.Clerks;
public class Clerks : BaseInfo
{
    private Clerks() { }

    #region props
    #region enums
    /// <summary>
    /// سمت شغلی
    /// </summary>
    public EnPosition Position { get; private set; }
    #endregion
    #region numbers
    /// <summary>
    /// شناسه کارمندی
    /// </summary>
    public long UserCode { get; private set; }
    #endregion
    #endregion

    public static Clerks Factory(
        string name,
        string lastName,
        string phoneNumber,
        DateTime birthdate,
        string nationalCode,
        bool gender,
        short nationalty,
        EnPosition position,
        string email,
        long userCode
        )
    {
        StringBuilder sb = new();
        sb.Append(name);
        sb.Append(' ');
        sb.Append(lastName);

        return new Clerks()
        {
            Name = name,
            LastName = lastName,
            PhoneNumber = phoneNumber,
            Birthdate = birthdate,
            FullName = sb.ToString(),
            NationalCode = nationalCode,
            Gender = gender,
            Nationalty = nationalty,
            Position = position,
            Email = email,
            UserCode = userCode
        };
    }
}
