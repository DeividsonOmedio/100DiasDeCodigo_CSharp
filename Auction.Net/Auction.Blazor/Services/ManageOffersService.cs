using Auction.Blazor.Services.Interfaces;
using Entities.Entities;
using System.Net.Http.Json;

namespace Auction.Blazor.Services
{
    public class ManageOffersService(HttpClient httpClient) : IManageOffersService
    {
        public HttpClient _httpClient = httpClient;

        public async Task<IEnumerable<OfferModel>?> GetAllOffers() =>
            await _httpClient.GetFromJsonAsync<IEnumerable<OfferModel>>($"ManageOffers/GetAllOffers");

        public Task<IEnumerable<OfferModel>?> GetAllOfferByIdAuction(int idAuction) =>
            _httpClient.GetFromJsonAsync<IEnumerable<OfferModel>>($"ManageOffers/getAllOfferById/{idAuction}");

        public async Task<IEnumerable<OfferModel>?> GetAllOffersByItem(int idItem)
        {
            var result = await _httpClient.GetFromJsonAsync<IEnumerable<OfferModel>>($"ManageOffers/getAllOffersByItem/{idItem}");
            return result;
        }

        public Task<IEnumerable<OfferModel>?> GetAllOffersByUser(int idUser) =>
            _httpClient.GetFromJsonAsync<IEnumerable<OfferModel>>($"ManageOffers/getAllOffersByUser");

        public Task<OfferModel?> GetMoreOfferByItem(int idItem) =>
            _httpClient.GetFromJsonAsync<OfferModel>($"ManageOffers/GetMoreOfferByItem/{idItem}");

        public Task<IEnumerable<OfferModel>?> GetOffersByUserByItem(int idUser, int idItem) =>
            _httpClient.GetFromJsonAsync<IEnumerable<OfferModel>>($"ManageOffers/GetOffersByUserByItem/{idUser}/{idItem}");

        public Task<IEnumerable<OfferModel>?> GetOffersInAuctionActive() =>
            _httpClient.GetFromJsonAsync<IEnumerable<OfferModel>>($"ManageOffers/GetOffersInAuctionActive");

        public Task<IEnumerable<OfferModel>?> GetOffersInAuctionClosed() =>
            _httpClient.GetFromJsonAsync<IEnumerable<OfferModel>>($"ManageOffers/");

    }
}
