using EducationalApi.Application.Users.Clerk.Queries.GetAll;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EducationalApi.App.Controllers;
[Route("api/[controller]/")]
[ApiController]
public class ClerckController : ControllerBase
{
    private readonly ISender _sender;
    public ClerckController(ISender sender)
    {
        _sender = sender;   
    }

    [HttpGet]
    public async Task<IActionResult> GetAllClercks(CancellationToken cancellationToken)
    {
        GetAllClerckQuery query = new();

        var response = await _sender.Send(query);

        return Ok(response);
    }
}
