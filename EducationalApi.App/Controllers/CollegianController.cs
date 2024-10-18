using EducationalApi.Application.Users.Collegians.Queries.GetAll;
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
    }
}
