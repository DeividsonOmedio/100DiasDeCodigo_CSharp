using Auction.Blazor.Services.Interfaces;
using Entities.Entities;
using System.Net.Http.Json;

namespace Auction.Blazor.Services
{
    public class ManageUsersService(HttpClient httpClient) : IManageUsersService
    {
        public HttpClient _httpClient = httpClient;

        public async Task<IEnumerable<UserModel>?> GetAllUsers()
        {
            var response = await _httpClient.GetFromJsonAsync<IEnumerable<UserModel>>("Users/GetAllUsers");
            return response;
        }

        public async Task<UserModel?> GetUserById(int id) => await _httpClient.GetFromJsonAsync<UserModel>($"Users/GetUserById/{id}");

        public async Task<IEnumerable<UserModel>?> GetByName(string name) => await _httpClient.GetFromJsonAsync<IEnumerable<UserModel>>($"Users/GetUserByName/{name}");

        public async Task<UserModel?> GetByEmail(string email) => await _httpClient.GetFromJsonAsync<UserModel>($"Users/GetUserByEmail/{email}");

        public async Task<string?> CreateUser(UserModel usuario)
        {
            var response = await _httpClient.PostAsJsonAsync<UserModel>("Users/CreateUser", usuario);
            return response.Content.ToString();
        }

        public async Task<string?> ChangeEmailUer(int id, string email)
        {
            var response = await _httpClient.PatchAsJsonAsync<UserModel>($"User/ChangeEmailUer/{id}/{email}", new UserModel());
            return response.Content.ToString();
        }

        public async Task<string?> ChangeNameUser(int id, string name)
        {
            var response = await _httpClient.PatchAsJsonAsync<UserModel>($"User/ChangeNameUser/{id}/{name}", new UserModel());
            return response.Content.ToString();
        }

        public async Task<string?> ChangePasswordUser(int id, string password)
        {
            var response = await _httpClient.PatchAsJsonAsync<UserModel>($"User/ChangePasswordUser/{id}/{password}", new UserModel());
            return response.Content.ToString();
        }

        public async Task<string?> DeleteUser(int id)
        {
            var response = await _httpClient.DeleteAsync($"DeleteUser/{id}");
            return response.Content.ToString();
        }
    }
}
