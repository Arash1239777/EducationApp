using EducationalApi.Application.Users.Masters.Commands.DeleteMaster.Contracts;
using EducationalApi.Domain.Enums;
using MediatR;
namespace EducationalApi.Application.Users.Masters.Commands.DeleteMaster
{
    public record DeleteMasterCommand:IRequest<DeleteMasterResponseContract>
    {
        public long MasterId { get; set; }
        public string Department { get; set; }
        public string Title { get; set; }
        public EnSpecialization Specialization { get; set; }
        public DateTime HireDate { get; set; }
        public double Salary { get; set; }
        public EnMasterStatus Status { get; set; }
    }
}
