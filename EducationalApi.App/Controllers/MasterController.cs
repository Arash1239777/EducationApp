using EducationalApi.Application.Users.Masters.Commands.DeleteMaster;
using EducationalApi.Application.Users.Masters.Commands.DeleteMaster.Contracts;
using EducationalApi.Application.Users.Masters.Commands.InsertMaster;
using EducationalApi.Application.Users.Masters.Commands.InsertMaster.Contracts;
using EducationalApi.Application.Users.Masters.Commands.UpdateMaster;
using EducationalApi.Application.Users.Masters.Commands.UpdateMaster.Contracts;
using EducationalApi.Application.Users.Masters.Queries.GetAll;
using Mapster;
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

        [HttpPost]
        public async Task<IActionResult> Create(InsertMasterRequestContract request,CancellationToken cancellationToken)
        {
            InsertMasterCommand command = request.Adapt<InsertMasterCommand>();

            InsertMasterResponseContract response = await _sender.Send(command, cancellationToken);

            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateMasterRequestContract request,CancellationToken cancellationToken)
        {
            UpdateMasterCommand command = request.Adapt<UpdateMasterCommand>();

            UpdateMasterResponseContract response = await _sender.Send(command, cancellationToken);

            return Ok(response);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(DeleteMasterRequestContract request,
            CancellationToken cancellationToken)
        {
            DeleteMasterCommand command = request.Adapt<DeleteMasterCommand>();

            DeleteMasterResponseContract response = await _sender.Send(command, cancellationToken);

            return Ok(response);
        }

    }
}
