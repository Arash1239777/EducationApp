using EducationalApi.Application.Users.Masters.Queries.GetAll.Contracts;
using MediatR;

namespace EducationalApi.Application.Users.Masters.Queries.GetAll;

public class GetAllMasterQuery : IRequest<List<GetMasterAllResponseContract>> { }
