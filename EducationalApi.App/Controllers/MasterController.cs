using EducationalApi.Application.Users.Masters.Queries.GetAll;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EducationalApi.App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MasterController : ControllerBase
    {
        private readonly ISender _sender;

        public MasterController(ISender sender)
        {
            _sender = sender;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllMaster(CancellationToken cancellationToken)
        {
            GetAllMasterQuery query = new();

            var response = await _sender.Send(query);

            return Ok(response);
        }

    }
}
