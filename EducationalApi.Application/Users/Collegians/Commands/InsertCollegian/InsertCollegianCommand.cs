using EducationalApi.Application.Users.Collegians.Commands.InsertCollegian.Contracts;
using EducationalApi.Domain.Enums;
using MediatR;

namespace EducationalApi.Application.Users.Collegians.Commands.InsertCollegian
{
    public class InsertCollegianCommand : IRequest<InsertCollegianResponseContract>
    {
        public short Nationalty { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string NationalCode { get; set; }
        public string Email { get; set; }
        public DateTime Birthdate { get; set; }
        public bool Gender { get; set; }

        public double GPA { get; set; }
        public string RoleNumber { get; set; }
        public string Major { get; set; }
        public string AcademicYear { get; set; }
        public DateTime Enrollment_date { get; set; }
        public EnCollegianStatus Status { get; set; }
    }
}
