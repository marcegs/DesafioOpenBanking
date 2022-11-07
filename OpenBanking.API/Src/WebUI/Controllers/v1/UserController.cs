using Application.User.Commands;
using Application.User.Commands.Logout;
using Application.User.Commands.RegisterUser;
using Application.User.Query.Login;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers.v1;

[Route("api/v1/[controller]")]
public class UserController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> RegisterUser([FromBody] RegisterUserCommand request)
    {
        await Mediator.Send(request);
        return NoContent();
    }
    [HttpPost("Login")]
    public async Task<ActionResult<LoginResponse>> Login([FromBody] LoginQuery request)
    {
        var response = await Mediator.Send(request);
        return Ok(response);
    }
    [HttpPost("Logout")]
    public async Task<IActionResult> Logout()
    {
        await Mediator.Send(new LogoutCommand());
        return NoContent();
    }
}