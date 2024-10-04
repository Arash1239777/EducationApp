using EducationalApi.Application.Users.Masters.Commands.InsertMaster.Contracts;
using EducationalApi.Domain.Entities.Exceptions.Users.Collegian;
using EducationalApi.Domain.Entities.Exceptions.Users.Masters;
using MediatR;

namespace EducationalApi.Application.Users.Masters.Commands.InsertMaster
{
    internal class InsertMasterHandler : IRequestHandler<InsertMasterCommand, InsertMasterResponseContract>
    {
        public async Task<InsertMasterResponseContract> Handle(InsertMasterCommand request, CancellationToken cancellationToken)
        {
            InsertMasterResponseContract response = new();
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