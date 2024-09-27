using Domain.Enums;
using EducationalApi.Application.Users.BaseContracts;

namespace EducationalApi.Application.Users.Clerk.Commands.InsertClerck.Contracts;
public record InsertClerckRequestContract : BaseUserContract
{
    #region enums
    /// <summary>
    /// سمت شغلی
    /// </summary>
    public EnPosition Position { get; set; }
    #endregion
    #region numbers
    /// <summary>
    /// شناسه کارمندی
    /// </summary>
    public long UserCode { get; set; }
    #endregion
}
