﻿using EducationalApi.Application.Users.Masters.Commands.InsertMaster.Contracts;
using EducationalApi.Domain.Enums;
using MediatR;

namespace EducationalApi.Application.Users.Masters.Commands.InsertMaster
{
    public class InsertMasterCommand : IRequest<InsertMasterResponseContract>
    {
        public string Department { get; set; }
        public string Title { get; set; }
        public EnSpecialization Specialization { get; set; }
        public DateTime Hire_date { get; set; }
        public double Salary { get; set; }
        public EnMasterStatus Status { get; set; }

    }
}
