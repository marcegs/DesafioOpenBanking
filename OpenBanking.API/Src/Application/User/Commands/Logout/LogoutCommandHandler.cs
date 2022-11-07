using Application.Interfaces;
using MediatR;

namespace Application.User.Commands.Logout;

public class LogoutCommandHandler : IRequestHandler<LogoutCommand, bool>
{
    private IApplicationUserServices _applicationUserServices;

    public LogoutCommandHandler(IApplicationUserServices applicationUserServices)
    {
        _applicationUserServices = applicationUserServices;
    }

    public async Task<bool> Handle(LogoutCommand request, CancellationToken cancellationToken)
    {
        await this._applicationUserServices.Logout();
        return true;
    }
}