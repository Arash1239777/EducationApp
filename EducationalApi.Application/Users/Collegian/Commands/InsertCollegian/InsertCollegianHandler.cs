using EducationalApi.Application.Users.Collegian.Commands.InsertCollegian;
using EducationalApi.Domain.Entities.Exceptions.Users.Collegian;
using MediatR;

namespace EducationalApi.Application.Users.Collegian.Commands.InsertClerck
{
    internal class InsertCollegianHandler : IRequestHandler<InsertCollegianCommand, bool>
    {
        public async Task<bool> Handle(InsertCollegianCommand request, CancellationToken cancellationToken)
        {
            try
            {

            }
            catch (CollegianExceptions ex)
            {

            }
            return true;
        }
    }
}