using MediatR;

namespace Application.User.Commands.RegisterUser;

public class RegisterUserCommand : IRequest<bool>
{
    public string username { get; set; }
    public string password { get; set; }
}