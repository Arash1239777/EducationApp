using EducationalApi.Application.Users.Collegians.Commands.UpdateCollegian.Contracts;
using EducationalApi.Domain.Enums;
using MediatR;

namespace EducationalApi.Application.Users.Collegians.Commands.UpdateCollegian
{
    public class UpdateCollegianCommand : IRequest<UpdateCollegianResponseContract>
    {
        public double GPA { get; set; }
        public string RoleNumber { get; set; }
        public string Major { get; set; }
        public string Academic_year { get; set; }
        public DateTime Enrollment_date { get; set; }
        public EnCollegianStatus Status { get; set; }
    }
}
