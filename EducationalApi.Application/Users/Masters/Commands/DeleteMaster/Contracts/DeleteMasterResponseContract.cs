namespace EducationalApi.Application.Users.Masters.Commands.DeleteMaster.Contracts;

public record DeleteMasterResponseContract()
{
    public bool Deleted { get; set; }
}