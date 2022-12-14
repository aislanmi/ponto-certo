namespace PontoCerto.WebApplication.Infrastructure.Security;

public interface IIdentityService
{
    Task<string> GetUserId(string userName);
    Task Register(string userName, string password);
    Task SignIn(string userName, string password);
    Task SignOut();
}