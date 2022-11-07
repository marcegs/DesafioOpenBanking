using Application.Interfaces;
using MediatR;

namespace Application.User.Query.Login;

public class LoginQueryHandler : IRequestHandler<LoginQuery, LoginResponse>
{
    private IApplicationUserServices _applicationUserServices;

    public LoginQueryHandler(IApplicationUserServices applicationUserServices)
    {
        _applicationUserServices = applicationUserServices;
    }

    public async Task<LoginResponse> Handle(LoginQuery request, CancellationToken cancellationToken)
    {
        var token = await _applicationUserServices.Login(request.username, request.password);
        return new LoginResponse
        {
            token = token
        };
    }
}