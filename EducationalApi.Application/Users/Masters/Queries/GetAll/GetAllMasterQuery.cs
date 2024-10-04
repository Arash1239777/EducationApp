using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EducationalApi.Application.Users.Collegian.Queries.GetAll.Contracts;
using EducationalApi.Application.Users.Masters.Queries.GetAll.Contracts;
using MediatR;

namespace EducationalApi.Application.Users.Masters.Queries.GetAll
{
    internal class GetAllMasterQuery : IRequest<List<GetMasterAllRequestContract>>, IRequest<GetAllCollegianResponseContract>
    {
    }
}
