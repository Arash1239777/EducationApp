using EducationalApi.Domain.Enums;
using MediatR;

namespace EducationalApi.Application.Users.Masters.Commands.InsertMaster
{
    internal class InsertMasterCommand : IRequest<bool>
    {
        public string department { get; protected set; }
        public string title { get; protected set; }
        public EnSpecialization specialization { get; protected set; }
        public DateTime Hire_date { get; protected set; }
        public double salary { get; protected set; }
        public EnMasterStatus Status { get; protected set; }

    }
}
