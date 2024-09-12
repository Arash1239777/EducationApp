using EducationalApi.Domain.Enums;
using MediatR;

namespace EducationalApi.Application.Users.Masters.Commands.InsertMaster
{
    internal class InsertMasterCommand : IRequest<bool>
    {
        public string department { get; set; }
        public string title { get; set; }
        public EnSpecialization specialization { get; set; }
        public DateTime Hire_date { get; set; }
        public double salary { get; set; }
        public EnMasterStatus Status { get; set; }

    }
}
