using Application.Participants.Commands.UpdateParticipants;
using Application.Participants.Queries.GetParticipants;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers.v1;

[Route("api/v1/[controller]")]
public class ParticipantController : BaseController
{
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var query = new GetParticipantsQuery();
        var response = await Mediator.Send(query);
        return Ok(response);
    }
    [HttpPost]
    public async Task<IActionResult> UpdateDatabase()
    {
        var query = new UpdateParticipantsCommand();
        await Mediator.Send(query);
        return NoContent();
    }
}