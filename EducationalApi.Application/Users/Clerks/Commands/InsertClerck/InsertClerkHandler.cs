using EducationalApi.Domain.Entities.Exceptions.Users.Clerck;
using MediatR;

namespace EducationalApi.Application.Users.Clerks.Commands.InsertClerck
{
    internal class InsertClerkHandler : IRequestHandler<InsertClerkCommand, bool>
    {
        public async Task<bool> Handle(InsertClerkCommand request, CancellationToken cancellationToken)
        {
            try
            {

            }
            catch (ClercksExeptions ex)
            {

            }
            return true;
        }
    }
}