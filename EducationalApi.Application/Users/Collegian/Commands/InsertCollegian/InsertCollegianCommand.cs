using EducationalApi.Domain.Enums;
using MediatR;

namespace EducationalApi.Application.Users.Collegian.Commands.InsertCollegian
{
    public class InsertCollegianCommand : IRequest<bool>
    {
        public double GPA { get; set; }
        public string RoleNumber { get; set; }
        public string Major { get; set; }
        public string Academic_year { get; set; }
        public DateTime Enrollment_date { get; set; }
        public EnCollegianStatus Status { get; set; }
    }
}
