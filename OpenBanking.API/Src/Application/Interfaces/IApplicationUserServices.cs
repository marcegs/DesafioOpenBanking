namespace Application.Interfaces;

public interface IApplicationUserServices
{
    Task Logout();
    Task RegisterUser(string username, string password);
    Task<string> Login(string username, string password);
}