using Auction.Blazor.Services.Interfaces;
using Entities.Entities;
using System.Net.Http;
using System.Net.Http.Json;

namespace Auction.Blazor.Services
{
    public class CreateOfferService(HttpClient httpClient) : ICreateOfferService
    {
        public HttpClient _httpClient = httpClient;
        public async Task<OfferModel> Execute(int itemId, RequestCreateOfferJson request)
        {
            var response = await _httpClient.PostAsJsonAsync($"/Offers/{itemId}", request);
            return await response.Content.ReadFromJsonAsync<OfferModel>();
        }
    }
}
