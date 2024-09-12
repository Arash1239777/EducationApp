using EducationalApi.Domain.Entities.Exceptions.Users.Masters;
using MediatR;

namespace EducationalApi.Application.Users.Masters.Commands.InsertMaster
{
    internal class InsertMasterHandler : IRequestHandler<InsertMasterCommand, bool>
    {
        public async Task<bool> Handle(InsertMasterCommand request, CancellationToken cancellationToken)
        {
            try
            {

            }
            catch (MastersExeptions ex)
            {

            }
            return true;
        }
    }
}