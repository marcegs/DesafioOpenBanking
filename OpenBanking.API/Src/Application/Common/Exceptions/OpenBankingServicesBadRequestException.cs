using Application.Common.Exceptions.Base;

namespace Application.Common.Exceptions;

public class OpenBankingServicesBadRequestException : BadRequestException
{
    public OpenBankingServicesBadRequestException(string message) : base(message)
    {
    }
}