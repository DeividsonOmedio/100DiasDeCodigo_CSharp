using Domain.Interfaces;
using Domain.Interfaces.RepositoryInterfaces;
using Entities.Entities;
using Infra.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repository
{
    public class AuctionRepository(AuctionDbContext auctionDbContext, ILoggedUser userLogged) : IAuctionRepository
    {
        private readonly AuctionDbContext _auctionDbContext = auctionDbContext;
        private readonly ILoggedUser _userLogged = userLogged;

        public async Task<List<AuctionModel>?> GetAll()
        {
            try
            {
                var result = await _auctionDbContext
                    .Auctions
                    .Include(auction => auction.Items)
                    .ToListAsync();
                return result;
            }
            catch
            {
                return null;
            }
        }


        public async Task<AuctionModel?> GetById(int id)
        {
            try
            {
                return await _auctionDbContext
                    .Auctions
                    .Include(auction => auction.Items)
                    .FirstOrDefaultAsync(auction => auction.Id == id);
            }
            catch
            {
                return null;
            }
        }
        public async Task<List<AuctionModel>?> GetByName(string name)
        {
            try
            {
                return await _auctionDbContext
                    .Auctions
                    .Include(auction => auction.Items)
                    .Where(auction => auction.Name.ToLower().Contains(name.ToLower())).ToListAsync();
            }
            catch
            {
                return null;
            }
        }
        public async Task<List<AuctionModel>?> GetCurrent()
        {
            try
            {
                return await _auctionDbContext
                    .Auctions
                    .Include(auction => auction.Items)
                    .Where(auction => auction.Starts <= DateTime.Now && auction.Ends >= DateTime.Now).ToListAsync();
            }
            catch
            {
                return null;
            }
        }
        
        public async Task<List<AuctionModel>?> GetByClosed()
        {
            try
            {
                return await _auctionDbContext
                    .Auctions
                    .Include(auction => auction.Items)
                    .Where(auction => auction.Ends < DateTime.Now).ToListAsync();
            }
            catch
            {
                return null;
            }
        }

        public async Task<List<AuctionModel>?> GetByDate(DateTime data)
        {
            try
            {
                return await _auctionDbContext
                    .Auctions
                    .Include(auction => auction.Items)
                    .Where(auction => data >= auction.Starts && data <= auction.Ends).ToListAsync();
            }
            catch
            {
                return null;
            }
        }

        public async Task<List<AuctionModel>?> GetByPeriod(DateTime dataInicial, DateTime dataFinal)
        {
            try
            {
                return await _auctionDbContext
                    .Auctions
                    .Include(auction => auction.Items)
                    .Where(auction => dataInicial <= auction.Starts && dataFinal >= auction.Starts || dataInicial <= auction.Ends && dataFinal >= auction.Starts).ToListAsync();
            }
            catch
            {
                return null;
            }
        }

        public async Task<List<AuctionModel>?> GetByProgrammed()
        {
            try
            {
                return await _auctionDbContext
                    .Auctions
                    .Include(auction => auction.Items)
                    .Where(auction => auction.Starts > DateTime.Now).ToListAsync();
            }
            catch
            {
                return null;
            }
        }

        public async Task<AuctionModel?> ChangeAuction(int id, AuctionModel leilao)
        {
            var result = await _auctionDbContext.Auctions.FirstOrDefaultAsync(auction => auction.Id == id);
            if (result == null) return null;
            try
            {
                result.Name = leilao.Name;
                result.Starts = leilao.Starts;
                result.Ends = leilao.Ends;
                _auctionDbContext.Update(result);
                await _auctionDbContext.SaveChangesAsync();
                return result;
            }
            catch
            {
                return null;
            }
        }

        public async Task<AuctionModel?> CreateNewAuction(AuctionModel novoLeilao)
        {
            var usuario = _userLogged.User();
            novoLeilao.UserId = usuario.Id;
            try
            {
                await _auctionDbContext.Auctions.AddAsync(novoLeilao);
                await _auctionDbContext.SaveChangesAsync();
                return novoLeilao;
            }
            catch
            {
                return null;
            }
        }
        public async Task<string> DeleteAuction(int id)
        {
            var result = await _auctionDbContext.Auctions.FirstOrDefaultAsync(auction => auction.Id == id);
            if (result == null) return "Não encontrado";
            try
            {
                _auctionDbContext.Auctions.Remove(result);
                await _auctionDbContext.SaveChangesAsync();
                return "Sucesso";
            }
            catch
            {
                return "Falha";
            }
        }
    }
}
