namespace EducationalApi.Application.Users.Masters.Commands.DeleteMaster.Contracts;

public record DeleteMasterRequestContract()
{
    public long MasterId { get; set; }
}