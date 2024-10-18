using EducationalApi.Application.Users.Collegians.Queries.GetAll.Contracts;
using MediatR;

namespace EducationalApi.Application.Users.Collegians.Queries.GetAll
{
    public class GetAllCollegianQuery: IRequest<List<GetAllCollegianResponseContract>>
    {
    }
}
