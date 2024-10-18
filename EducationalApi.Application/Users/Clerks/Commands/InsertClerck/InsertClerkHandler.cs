using EducationalApi.Domain.Entities;
using EducationalApi.Domain.Entities.Exceptions.Users.Clerck;
using Domain.Entities.Aggrigators.Users.Clerk;
using MediatR;
using EducationalApi.Application.Users.Clerk.Commands.InsertClerck.Contracts;

namespace EducationalApi.Application.Users.Clerk.Commands.InsertClerck;
internal class InsertClerkHandler : IRequestHandler<InsertClerkCommand, InsertClerckResponseContract>
{
    private readonly IUnitOfWork _unitOfWork;
    public InsertClerkHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<InsertClerckResponseContract> Handle(InsertClerkCommand request, CancellationToken cancellationToken)
    {
        InsertClerckResponseContract response = new();
        try
        {
            Clerks clerk = await Clerks.Factory(
                request.Name,
                request.LastName,
                request.PhoneNumber,
                request.Birthdate,
                request.NationalCode,
                request.Gender,
                request.Nationalty,
                request.Position,
                request.Email,
                request.UserCode);

            _unitOfWork.ClerckRepository.Add(clerk);

           await _unitOfWork.SaveChangesAsync(cancellationToken);

            response.IsCreated = true;
        }
        catch (ClercksExeptions ex)
        {
            throw new NotImplementedException();
        }
        return response;
    }
}