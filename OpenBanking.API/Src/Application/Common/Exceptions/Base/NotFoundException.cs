namespace Application.Common.Exceptions.Base;

public class NotFoundException : Exception
{
    public NotFoundException(string message) : base(message)
    {
    }
}