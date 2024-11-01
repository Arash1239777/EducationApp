using EducationalApi.Application.Users.BaseContracts;
using EducationalApi.Application.Users.Masters.Commands.InsertMaster.Contracts;
using EducationalApi.Domain.Enums;
using MediatR;

namespace EducationalApi.Application.Users.Masters.Commands.InsertMaster
{
    public record InsertMasterCommand : IRequest<InsertMasterResponseContract>
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
        public string Department { get; set; }
        public string Title { get; set; }
        public EnSpecialization Specialization { get; set; }
        public DateTime HireDate { get; set; }
        public double Salary { get; set; }
        public EnMasterStatus Status { get; set; }

    }
}
