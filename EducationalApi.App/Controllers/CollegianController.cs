using EducationalApi.Application.Users.Collegians.Commands.InsertCollegian;
using EducationalApi.Application.Users.Collegians.Commands.InsertCollegian.Contracts;
using EducationalApi.Application.Users.Collegians.Queries.GetAll;
using Mapster;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EducationalApi.App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CollegianController : ControllerBase
    {
        private readonly ISender _sender;

        public CollegianController(ISender sender)
        {
            _sender = sender;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCollegian(CancellationToken cancellationToken)
        {
            GetAllCollegianQuery query = new();

            var reponse =await _sender.Send(query);

            return Ok(reponse);
        }

        [HttpPost]
        public async Task<IActionResult> Create(InsertCollegianRequestContract request,CancellationToken cancellationToken)
        {
            InsertCollegianCommand command = request.Adapt<InsertCollegianCommand>();

            InsertCollegianResponseContract response = await _sender.Send(command, cancellationToken);

            return Ok(response);
        }
    }
}
