using Domain.Entities.Aggrigators.Users.Master;
using EducationalApi.Application.Users.Masters.Commands.DeleteMaster.Contracts;
using EducationalApi.Domain.Entities;
using EducationalApi.Domain.Entities.Exceptions.Users.Masters;
using MediatR;

namespace EducationalApi.Application.Users.Masters.Commands.DeleteMaster;

internal class DeleteMasterHandler:IRequestHandler<DeleteMasterCommand,DeleteMasterResponseContract>
{
    private readonly IUnitOfWork _unitOfWork;
    public DeleteMasterHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    public async Task<DeleteMasterResponseContract> Handle(DeleteMasterCommand request, CancellationToken cancellationToken)
    {
        DeleteMasterResponseContract response = new() { Deleted = true};
        try
        {
            Master? master =await _unitOfWork.MasterRepository.FindMastersAsync(request.MasterId);
            if (master is null)
                return new DeleteMasterResponseContract() { Deleted = true };

             _unitOfWork.MasterRepository.Delete(master);

             await _unitOfWork.SaveChangesAsync(cancellationToken);

        }
        catch (MastersExeptions e)
        {
            return new DeleteMasterResponseContract() { Deleted = false };
        }

        return response;
    }
}