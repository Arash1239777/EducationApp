using EducationalApi.Application.Users.Clerk.Queries.GetAll.Contracts;
using EducationalApi.Application.Users.Collegian.Queries.GetAll.Contracts;
using MediatR;

namespace EducationalApi.Application.Users.Collegians.Queries.GetAll
{
    public class GetAllCollegianQuery: IRequest<List<GetAllCollegianResponseContract>>
    {
    }
}
