using EducationalApi.Application.Users.Collegian.Queries.GetAll.Contracts;
using EducationalApi.Application.Users.Collegians.Queries.GetAll;
using EducationalApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mapster;

namespace EducationalApi.Application.Users.Masters.Queries.GetAll
{
    internal class GetAllMasterHandler
    {
        private readonly IUnitOfWork _unitOfWork;
        public GetAllMasterHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<GetAllMasterHandler>> Handle(GetAllMasterHandler request, CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.CollegianRepository.GetAll(cancellationToken);

            var response = result.Adapt<List<GetAllMasterHandler>>();

            return response;
        }
    }
}
