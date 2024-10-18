using Domain.Entities.Aggrigators.Users.Collegians;
using EducationalApi.Application.Users.Collegians.Commands.InsertCollegian;
using EducationalApi.Application.Users.Collegians.Commands.InsertCollegian.Contracts;
using EducationalApi.Domain.Entities;
using EducationalApi.Domain.Entities.Exceptions.Users.Collegians;
using MediatR;

namespace EducationalApi.Application.Users.Collegians.Commands.InsertClerck;

internal class InsertCollegianHandler : IRequestHandler<InsertCollegianCommand, InsertCollegianResponseContract>
{
    private readonly IUnitOfWork _unitOfWork;

    public InsertCollegianHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<InsertCollegianResponseContract> Handle(InsertCollegianCommand request, CancellationToken cancellationToken)
    {
        InsertCollegianResponseContract response = new();
        try
        {
            Collegian collegian = await Collegian.Factory(
                request.Name,
                request.LastName,
                request.PhoneNumber,
                request.Birthdate,
                request.NationalCode,
                request.Gender,
                request.Nationalty,
                request.Email,
                request.GPA,
                request.RoleNumber,
                request.Major,
                request.AcademicYear,
                request.Enrollment_date,
                request.Status
            );

            _unitOfWork.CollegianRepository.Add(collegian);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            response.IsCreated = true;
        }
        catch (CollegianExceptions ex)
        {
            throw new NotImplementedException();
        }
        return response;
    }
}