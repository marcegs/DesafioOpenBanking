using Application.Common.Exceptions.Base;

namespace Application.Common.Exceptions;

public class UserCreationFailedException : BadRequestException
{
    public UserCreationFailedException(string message) : base(message)
    {
    }
}