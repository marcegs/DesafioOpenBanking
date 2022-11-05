using Application.Participants.Commands.UpdateParticipants;
using Application.Participants.Queries.GetParticipants;
using Application.Participants.Queries.GetParticipantsById;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers.v1;

[Route("api/v1/[controller]")]
public class ParticipantController : BaseController
{
    [HttpGet]
    public async Task<ActionResult<GetParticipantsResponse>> Get()
    {
        var response = await Mediator.Send(new GetParticipantsQuery());
        return Ok(response);
    }

    [HttpGet("{id:guid}")]
    public async Task<ActionResult<GetParticipantsByIdResponse>> GetById(Guid id)
    {
        var response = await Mediator.Send(new GetParticipantsByIdQuery { id = id });
        return Ok(response);
    }

    [HttpPost]
    public async Task<IActionResult> UpdateDatabase()
    {
        await Mediator.Send(new UpdateParticipantsCommand());
        return NoContent();
    }
}