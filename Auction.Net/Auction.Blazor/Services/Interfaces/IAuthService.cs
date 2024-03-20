using System.Net.Http.Headers;

namespace Auction.Blazor.Services.Interfaces
{
    public interface IAuthService
    {
        AuthenticationHeaderValue TokenAuthentication(string token);
        Task<string?> GetToken(string email, string password);
        Task Logout();
    }
}
