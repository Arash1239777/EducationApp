using EducationalApi.Application.Users.Clerk.Queries.GetAll.Contracts;
using EducationalApi.Domain.Entities;
using Mapster;
using MediatR;

namespace EducationalApi.Application.Users.Clerk.Queries.GetAll;
internal class GetAllClerckHandler : IRequestHandler<GetAllClerckQuery, List<GetAllClerckResponseContract>>
{
    private readonly IUnitOfWork _unitOfWork;

    public GetAllClerckHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<List<GetAllClerckResponseContract>> Handle(
        GetAllClerckQuery request,
        CancellationToken cancellationToken)
    {
        var result = await _unitOfWork.ClerckRepository.GetAll(cancellationToken);

        var response = result.Adapt<List<GetAllClerckResponseContract>>();

        return response;
    }
}
