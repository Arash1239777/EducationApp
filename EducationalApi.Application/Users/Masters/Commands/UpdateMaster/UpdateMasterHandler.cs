using EducationalApi.Application.Users.Masters.Commands.InsertMaster.Contracts;
using EducationalApi.Application.Users.Masters.Commands.InsertMaster;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EducationalApi.Application.Users.Masters.Commands.UpdateMaster.Contracts;
using EducationalApi.Domain.Entities.Exceptions.Users.Masters;

namespace EducationalApi.Application.Users.Masters.Commands.UpdateMaster
{
    internal class UpdateMasterHandler : IRequestHandler<UpdateMasterCommand, UpdateMasterResponseContract>
    {
        public async Task<UpdateMasterResponseContract> Handle(UpdateMasterCommand request, CancellationToken cancellationToken)
        {
            UpdateMasterResponseContract response = new();
            try
            {
                //No Implement.
            }
            catch (MastersExeptions ex)
            {
                throw new NotImplementedException();
            }
            return response;
        }
    }
}
