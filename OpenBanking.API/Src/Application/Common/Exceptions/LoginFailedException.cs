using Application.Common.Exceptions.Base;

namespace Application.Common.Exceptions;

public class LoginFailedException : BadRequestException
{
    public LoginFailedException() : base()
    {
        
    }
    public LoginFailedException(string message) : base(message)
    {
    }
}