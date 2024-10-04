using Domain.Entities.Aggrigators.Users.Master;
using EducationalApi.Application.Users.Masters.Commands.InsertMaster.Contracts;
using EducationalApi.Domain.Entities;
using EducationalApi.Domain.Entities.Exceptions.Users.Masters;
using MediatR;

namespace EducationalApi.Application.Users.Masters.Commands.InsertMaster;
internal class InsertMasterHandler : IRequestHandler<InsertMasterCommand, InsertMasterResponseContract>
{
    private readonly IUnitOfWork _unitOfWork;
    public InsertMasterHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    public async Task<InsertMasterResponseContract> Handle(InsertMasterCommand request, CancellationToken cancellationToken)
    {
        InsertMasterResponseContract response = new() { Created = true };
        try
        {
            Master master = await Master.Factory(
                request.Name,
                request.LastName,
                request.PhoneNumber,
                request.Birthdate,
                request.NationalCode,
                request.Gender,
                request.Nationalty,
                request.Email,
                request.Department,
                request.Title,
                request.Specialization,
                request.Hire_date,
                request.Salary,
                request.Status);

            _unitOfWork.MasterRepository.Add(master);

            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }
        catch (MastersExeptions ex)
        {
            return new InsertMasterResponseContract() { Created = false };
        }
        return response;
    }
}