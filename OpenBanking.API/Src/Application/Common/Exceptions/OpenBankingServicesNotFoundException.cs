using Application.Common.Exceptions.Base;

namespace Application.Common.Exceptions;

public class OpenBankingServicesNotFoundException : NotFoundException
{
    public OpenBankingServicesNotFoundException(string message) : base(message)
    {
    }
}