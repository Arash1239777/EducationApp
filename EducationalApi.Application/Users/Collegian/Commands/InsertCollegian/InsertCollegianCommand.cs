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
        public double GPA { get; set; }
        public string RoleNumber { get; set; }
        public string major { get; set; }
        public string academic_year { get; set; }
        public DateTime enrollment_date { get; set; }
        public EnCollegianStatus Status { get; set; }
    }
}
