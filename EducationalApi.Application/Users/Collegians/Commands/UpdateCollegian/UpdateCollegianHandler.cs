using EducationalApi.Application.Users.Collegians.Commands.UpdateCollegian.Contracts;
using MediatR;
using EducationalApi.Domain.Entities.Exceptions.Users.Collegian;
using EducationalApi.Domain.Entities;

namespace EducationalApi.Application.Users.Collegians.Commands.UpdateCollegian
{
    public class UpdateCollegianHandler: IRequestHandler<UpdateCollegianCommand, UpdateCollegianResponseContract>
    {
        private readonly IUnitOfWork _unitOfWork;

        public UpdateCollegianHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<UpdateCollegianResponseContract> Handle(UpdateCollegianCommand request, CancellationToken cancellationToken)
        {
            UpdateCollegianResponseContract response = new();
            try
            {
                //No Implement.
            }
            catch (CollegianExceptions ex)
            {
                throw new NotImplementedException();
            }
            return response;
        }
    }
}
