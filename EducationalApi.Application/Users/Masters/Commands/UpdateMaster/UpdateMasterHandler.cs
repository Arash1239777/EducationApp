using Domain.Entities.Aggrigators.Users.Master;
using EducationalApi.Application.Users.Masters.Commands.UpdateMaster.Contracts;
using EducationalApi.Domain.Entities;
using EducationalApi.Domain.Entities.Exceptions.Users.Masters;
using MediatR;

namespace EducationalApi.Application.Users.Masters.Commands.UpdateMaster;
internal class UpdateMasterHandler : IRequestHandler<UpdateMasterCommand, UpdateMasterResponseContract>
{
    private readonly IUnitOfWork _unitOfWork;
    public UpdateMasterHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    public async Task<UpdateMasterResponseContract> Handle(UpdateMasterCommand request, CancellationToken cancellationToken)
    {
        UpdateMasterResponseContract response = new() { Updated = true };
        try
        {
            Master? master = await _unitOfWork.MasterRepository.FindMastersAsync(request.MasterId);

            if (master is null)
                return new UpdateMasterResponseContract() { Updated = false };

            master.Update(
                request.Title,
                request.Specialization,
                request.HireDate,
                request.Salary,
                request.Status
                );

            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }
        catch (MastersExeptions ex)
        {
            return new UpdateMasterResponseContract() { Updated = false };
        }
        return response;
    }
}
