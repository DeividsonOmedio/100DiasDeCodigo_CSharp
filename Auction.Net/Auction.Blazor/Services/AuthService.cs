using Auction.Blazor.Services.Interfaces;
using BlazorAppAgenda.Client;
using Blazored.LocalStorage;
using Entities.Entities;
using Microsoft.AspNetCore.Components.Authorization;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text;
using Auction.Blazor.Shared;

namespace Auction.Blazor.Services
{
    public class AuthService(HttpClient httpClient, AuthenticationStateProvider authenticationStateProvider, ILocalStorageService localStorage) : IAuthService
    {
        public HttpClient _httpClient = httpClient;
        private readonly AuthenticationStateProvider _authenticationStateProvider = authenticationStateProvider;
        private readonly ILocalStorageService _localStorage = localStorage;

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
                await _localStorage.SetItemAsync("authToken", tokenResponse.Token);
                ((ApiAuthenticationStateProvider)_authenticationStateProvider)
                    .MarkUserAsAuthenticated(email);
                await ((ApiAuthenticationStateProvider)_authenticationStateProvider).GetAuthenticationStateAsync();
                _httpClient.DefaultRequestHeaders.Authorization = new
                    AuthenticationHeaderValue("bearer", tokenResponse.Token);
                return tokenResponse.Token;
            }
            return null;
        }       
        public async Task<RegisterResult> Register(UserModel registerModel)
        {
            var messageResult = await _httpClient.PostAsJsonAsync("api/account", registerModel);
            var result = await messageResult.Content.ReadFromJsonAsync<RegisterResult>();
            return result;
        }
        public async Task Logout()
        {
            await _localStorage.RemoveItemAsync("authToken");
            ((ApiAuthenticationStateProvider)_authenticationStateProvider).MarkUserAsLoggedOut();
            _httpClient.DefaultRequestHeaders.Authorization = null;
        }
    }
}

