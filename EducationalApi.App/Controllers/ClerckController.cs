using EducationalApi.Application.Users.Clerk.Commands.InsertClerck;
using EducationalApi.Application.Users.Clerk.Commands.InsertClerck.Contracts;
using EducationalApi.Application.Users.Clerk.Queries.GetAll;
using EducationalApi.Application.Users.Clerk.Queries.GetAll.Contracts;
using Mapster;
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

        List<GetAllClerckResponseContract> response = await _sender.Send(query, cancellationToken);

        return Ok(response);
    }

    [HttpPost]
    public async Task<IActionResult> Create(InsertClerckRequestContract request, CancellationToken cancellationToken)
    {
        InsertClerkCommand command = request.Adapt<InsertClerkCommand>();

        InsertClerckResponseContract resopne = await _sender.Send(command, cancellationToken);

        return Ok(resopne);
    }
}
