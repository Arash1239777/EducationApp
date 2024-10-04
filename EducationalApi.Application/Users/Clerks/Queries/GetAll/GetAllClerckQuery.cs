using EducationalApi.Application.Users.Clerk.Queries.GetAll.Contracts;
using MediatR;

namespace EducationalApi.Application.Users.Clerk.Queries.GetAll;
public class GetAllClerckQuery : IRequest<List<GetAllClerckResponseContract>>, IRequest<GetAllClerckResponseContract>
{
}
