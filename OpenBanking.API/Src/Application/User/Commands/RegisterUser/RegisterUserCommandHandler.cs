using Application.Interfaces;
using MediatR;

namespace Application.User.Commands.RegisterUser;

public class RegisterUserCommandHandler : IRequestHandler<RegisterUserCommand, bool>
{
    private readonly IApplicationUserServices _applicationUserServices;

    public RegisterUserCommandHandler(IApplicationUserServices applicationUserServices)
    {
        _applicationUserServices = applicationUserServices;
    }

    public async Task<bool> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
    {
        await _applicationUserServices.RegisterUser(request.username, request.password);
        return true;
    }
}