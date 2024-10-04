using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationalApi.Application.Users.Collegian.Commands.InsertCollegian.Contracts
{
    public record InsertCollegianResponseContract
    {
        public bool IsCreated { get; set; }
    }
}
