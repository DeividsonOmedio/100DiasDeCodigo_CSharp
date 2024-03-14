using Auction.Blazor.Services.Interfaces;
using Entities.Entities;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace Auction.Blazor.Services
{
    public class AuthService(HttpClient httpClient) : IAuthService
    {
        public HttpClient _httpClient = httpClient;


        public AuthenticationHeaderValue TokenAuthentication(string token)
        {

            var response = _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("X-Auth-Token", "Bearer " + token);
            return response;
        }

        public async Task<string?> GetToken(string email, string password)
        {
            var response = await _httpClient.PostAsJsonAsync($"Token/Auth/{email}/{password}", new UserModel());
            var tokenResponse = await response.Content.ReadFromJsonAsync<TokenResponse>();

            if (tokenResponse != null)
            {
                // Configure os cabeçalhos de autenticação com o token
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", tokenResponse.Token);

                return tokenResponse.Token;
            }

            return null;
        }
    }
}

