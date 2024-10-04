using EducationalApi.Application.Users.Collegian.Commands.InsertCollegian;
using EducationalApi.Application.Users.Collegian.Commands.InsertCollegian.Contracts;
using EducationalApi.Domain.Entities;
using EducationalApi.Domain.Entities.Exceptions.Users.Collegian;
using MediatR;

namespace EducationalApi.Application.Users.Collegian.Commands.InsertClerck;

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
            //No Implement.
        }
        catch (CollegianExceptions ex)
        {
            throw new NotImplementedException();
        }
        return response;
    }
}