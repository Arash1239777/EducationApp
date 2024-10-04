using EducationalApi.Application.Users.Clerk.Queries.GetAll;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EducationalApi.App.Controllers;
[Route("api/[controller]/")]
[ApiController]
public class ClerckController : ControllerBase
{
    private readonly IMediator _mediator;
    public ClerckController(IMediator mediator)
    {
        _mediator = mediator;   
    }

    [HttpGet]
    public async Task<IActionResult> GetAllClercks(CancellationToken cancellationToken)
    {
        GetAllClerckQuery query = new();

        var response = await _mediator.Send(query);

        return Ok(response);
    }
}
