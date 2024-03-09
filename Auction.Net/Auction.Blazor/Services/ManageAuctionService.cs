using Auction.Blazor.Services.Interfaces;
using Entities.Entities;
using System.Net.Http.Json;

namespace Auction.Blazor.Services
{
    public class ManageAuctionService(HttpClient httpClient) : IManageAuctionService
    {
        public HttpClient _httpClient = httpClient;
        public async Task<List<AuctionModel>?> GetAll()
        {
            try
            {
            var result = await _httpClient
                .GetFromJsonAsync<List<AuctionModel>>("Auction/GetAllAuction");
                return result;
            }
            catch(Exception ex)
            {
                throw new NotImplementedException();
            }
        }
        public async Task<AuctionModel?> GetById(int id)
        {
            try
            {
                var result = await _httpClient
                    .GetFromJsonAsync<AuctionModel>($"Auction/GetAuctionById/{id}");
                return result;
            }
            catch (Exception ex)
            {
                throw new NotImplementedException();
            }
        }
        public Task<IEnumerable<AuctionModel>?> GetByClosed()
        {
            throw new NotImplementedException();
        }
        public Task<IEnumerable<AuctionModel>?> GetByDate(DateTime data)
        {
            throw new NotImplementedException();
        }


        public Task<IEnumerable<AuctionModel>?> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AuctionModel>?> GetByPeriod(DateTime dataInicial, DateTime dataFinal)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AuctionModel>?> GetByProgrammed()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AuctionModel>?> GetCurrent()
        {
            throw new NotImplementedException();
        }

        public async Task<AuctionModel?> ChangeAuction(int id, AuctionModel leilao)
        {
            throw new NotImplementedException();
        }

        public Task<AuctionModel?> CreateNewAuction(AuctionModel novoLeilao)
        {
            throw new NotImplementedException();
        }

        public Task<string> DeleteAuction(int id)
        {
            throw new NotImplementedException();
        }
    }
}
