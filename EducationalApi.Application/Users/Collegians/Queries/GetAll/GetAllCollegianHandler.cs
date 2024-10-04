using EducationalApi.Application.Users.Collegian.Queries.GetAll.Contracts;
using EducationalApi.Domain.Entities;
using Mapster;
using MediatR;

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
