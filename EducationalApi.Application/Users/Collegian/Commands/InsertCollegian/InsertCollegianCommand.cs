using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EducationalApi.Domain.Enums;
using MediatR;

namespace EducationalApi.Application.Users.Collegian.Commands.InsertCollegian
{
    internal class InsertCollegianCommand : IRequest<bool>
    {
        public double GPA { get; protected set; }
        public string RoleNumber { get; protected set; }
        public string major { get; protected set; }
        public string academic_year { get; protected set; }
        public DateTime enrollment_date { get; protected set; }
        public EnCollegianStatus Status { get; protected set; }
    }
}
