using EducationalApi.Application.Users.Masters.Commands.UpdateMaster.Contracts;
using EducationalApi.Domain.Enums;
using MediatR;

namespace EducationalApi.Application.Users.Masters.Commands.UpdateMaster;
public record UpdateMasterCommand :IRequest<UpdateMasterResponseContract>
{
    public long MasterId { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string Department { get; set; }
    public string Title { get; set; }
    public EnSpecialization Specialization { get; set; }
    public DateTime HireDate { get; set; }
    public double Salary { get; set; }
    public EnMasterStatus Status { get; set; }
}
