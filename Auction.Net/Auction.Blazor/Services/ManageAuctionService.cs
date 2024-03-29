using Auction.Blazor.Services.Interfaces;
using Entities.Entities;
using System.Net.Http.Json;

namespace Auction.Blazor.Services
{
    public class ManageAuctionService(HttpClient httpClient) : IManageAuctionService
    {
        public HttpClient _httpClient = httpClient;
        public async Task<IEnumerable<AuctionModel>?> GetAll()
        {
            try
            {
            return await _httpClient
                .GetFromJsonAsync<IEnumerable<AuctionModel>>("Auction/GetAllAuction");
            }
            catch(Exception)
            {
                throw new NotImplementedException();
            }
        }
        public async Task<AuctionModel?> GetById(int id)
        {
            try
            {
                return await _httpClient
                    .GetFromJsonAsync<AuctionModel>($"Auction/GetAuctionById/{id}");
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
        public async Task<IEnumerable<AuctionModel>?> GetByUser(int idUser)
        {
            try
            {
                return await _httpClient
                    .GetFromJsonAsync<IEnumerable<AuctionModel>>($"Auction/GetByUser/{idUser}");
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
        public async Task<AuctionModel?> GetByName(string name)
        {
            try
            {
                return await _httpClient
                    .GetFromJsonAsync<AuctionModel>($"GetAuctionByName/{name}");
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
        public async Task<IEnumerable<AuctionModel>?> GetCurrent()
        {
            try
            {
                return await _httpClient
                .GetFromJsonAsync<IEnumerable<AuctionModel>>("Auction/GetAuctionCurrent");
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
        public async Task<IEnumerable<AuctionModel>?> GetByClosed()
        {
            try
            {
                return await _httpClient
                .GetFromJsonAsync<IEnumerable<AuctionModel>>("Auction/GetAllAuction");
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
        public async Task<IEnumerable<AuctionModel>?> GetByDate(DateTime data)
        {
            try
            {
                return await _httpClient
                .GetFromJsonAsync<IEnumerable<AuctionModel>>("Auction/GetAllAuction");
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public async Task<IEnumerable<AuctionModel>?> GetByPeriod(DateTime dataInicial, DateTime dataFinal)
        {
            try
            {
                return await _httpClient
                .GetFromJsonAsync<IEnumerable<AuctionModel>>("Auction/GetAllAuction");
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
        public async Task<IEnumerable<AuctionModel>?> GetByProgrammed()
        {
            try
            {
                return await _httpClient
                .GetFromJsonAsync<IEnumerable<AuctionModel>>("Auction/GetAllAuction");
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
        public async Task<AuctionModel?> ChangeAuction(int id, AuctionModel leilao)
        {
            try
            {
                var result = await _httpClient.PutAsJsonAsync<AuctionModel>($"Auction/ChangeAuction/{id}", leilao);
                return await result.Content.ReadFromJsonAsync<AuctionModel>();
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
        public async Task<AuctionModel?> CreateNewAuction(AuctionModel novoLeilao)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync<AuctionModel>("Auction/CreateAuction", novoLeilao);
                return await response.Content.ReadFromJsonAsync<AuctionModel>();
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
        public async Task<string?> DeleteAuction(int id)
        {
            try
            {
                return await _httpClient
                    .GetFromJsonAsync<string>($"Auction/GetAuctionById/{id}");
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}
