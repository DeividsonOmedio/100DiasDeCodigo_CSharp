using Entities.Entities;

namespace Auction.Blazor.Services.Interfaces
{
    public interface IManageAuctionService
    {
        Task<IEnumerable<AuctionModel>?> GetAll();
        Task<AuctionModel?> GetById(int id);
        Task<IEnumerable<AuctionModel>?> GetByName(string name);
        Task<IEnumerable<AuctionModel>?> GetByDate(DateTime data);
        Task<IEnumerable<AuctionModel>?> GetByPeriod(DateTime dataInicial, DateTime dataFinal);
        Task<IEnumerable<AuctionModel>?> GetCurrent();
        Task<IEnumerable<AuctionModel>?> GetByProgrammed();
        Task<IEnumerable<AuctionModel>?> GetByClosed();
        Task<AuctionModel?> CreateNewAuction(AuctionModel novoLeilao);
        Task<AuctionModel?> ChangeAuction(int id, AuctionModel leilao);
        Task<string> DeleteAuction(int id);
    }
}
