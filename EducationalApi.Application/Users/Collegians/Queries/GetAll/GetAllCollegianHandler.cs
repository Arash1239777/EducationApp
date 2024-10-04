using EducationalApi.Application.Users.Clerk.Queries.GetAll.Contracts;
using EducationalApi.Application.Users.Clerk.Queries.GetAll;
using EducationalApi.Application.Users.Collegian.Queries.GetAll.Contracts;
using MediatR;
using EducationalApi.Domain.Entities;
using Mapster;

namespace EducationalApi.Application.Users.Collegians.Queries.GetAll
{
    internal class GetAllCollegianHandler : IRequestHandler<GetAllCollegianQuery, List<GetAllCollegianResponseContract>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public GetAllCollegianHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<GetAllCollegianResponseContract>> Handle(GetAllCollegianQuery request, CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.CollegianRepository.GetAll(cancellationToken);

            var response = result.Adapt<List<GetAllCollegianResponseContract>>();

            return response;
        }
    }
}
