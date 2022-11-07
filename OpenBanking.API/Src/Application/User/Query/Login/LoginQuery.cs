using MediatR;

namespace Application.User.Query.Login;

public class LoginQuery : IRequest<LoginResponse>
{
    public string username { get; set; }
    public string password { get; set; }
}