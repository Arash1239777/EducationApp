using EducationalApi.Application.Users.Masters.Commands.UpdateMaster.Contracts;
using EducationalApi.Domain.Enums;
using MediatR;

namespace EducationalApi.Application.Users.Masters.Commands.UpdateMaster
{
    public class UpdateMasterCommand :IRequest<UpdateMasterResponseContract>
    {
        public string Department { get; set; }
        public string Title { get; set; }
        public EnSpecialization Specialization { get; set; }
        public DateTime Hire_date { get; set; }
        public double Salary { get; set; }
        public EnMasterStatus Status { get; set; }
    }
}
