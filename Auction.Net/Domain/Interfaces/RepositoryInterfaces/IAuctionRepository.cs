using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.RepositoryInterfaces
{
    public interface IAuctionRepository
    {
        Task<List<AuctionModel>?> GetAll();
        Task<AuctionModel?> GetById(int id);
        Task<List<AuctionModel>?> GetByName(string name);
        Task<List<AuctionModel>?> GetByDate(DateTime data);
        Task<List<AuctionModel>?> GetByPeriod(DateTime dataInicial, DateTime dataFinal);
        Task<List<AuctionModel>?> GetCurrent();
        Task<List<AuctionModel>?> GetByProgrammed();
        Task<List<AuctionModel>?> GetByClosed();
        Task<AuctionModel?> CreateNewAuction(AuctionModel novoLeilao);
        Task<AuctionModel?> ChangeAuction(int id, AuctionModel leilao);
        Task<string> DeleteAuction(int id);
    }
}
