﻿using EducationalApi.Application.Users.BaseContracts;
using EducationalApi.Domain.Enums;

namespace EducationalApi.Application.Users.Masters.Commands.UpdateMaster.Contracts
{

    public record UpdateMasterRequestContract
    {
        public long MasterId { get; set; }
        public string Title { get; set; }
        public EnSpecialization Specialization { get; set; }
        public DateTime HireDate { get; set; }
        public double Salary { get; set; }
        public EnMasterStatus Status { get; set; }

    }
}