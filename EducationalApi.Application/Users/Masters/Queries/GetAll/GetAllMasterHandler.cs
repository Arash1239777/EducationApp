using EducationalApi.Application.Users.Masters.Queries.GetAll.Contracts;
using EducationalApi.Domain.Entities;
using Mapster;
using MediatR;

namespace EducationalApi.Application.Users.Masters.Queries.GetAll;
internal class GetAllMasterHandler : IRequestHandler<GetAllMasterQuery, List<GetMasterAllResponseContract>>
{
    private readonly IUnitOfWork _unitOfWork;
    public GetAllMasterHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<List<GetMasterAllResponseContract>> Handle(GetAllMasterQuery request, CancellationToken cancellationToken)
    {
        var result = await _unitOfWork.MasterRepository.GetAll(cancellationToken);

        var response = result.Adapt<List<GetMasterAllResponseContract>>();

        return response;
    }
}
