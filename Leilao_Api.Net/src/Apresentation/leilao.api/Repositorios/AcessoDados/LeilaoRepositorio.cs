using leilao.api.Entities;
using leilao.api.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace leilao.api.Repositorios.AcessoDados
{
    public class LeilaoRepositorio : ILeilaoCasosDeUso
    {
        private readonly LeilaoDbContext _leilaoDbContext;

        public LeilaoRepositorio(LeilaoDbContext leilaoDbContext) => _leilaoDbContext = leilaoDbContext;


        public async Task<List<LeilaoModel>?> GetAll()
        {
            try
            {
                return await _leilaoDbContext
                    .Auctions
                    .Include(auction => auction.Items)
                    .ToListAsync();
            }
            catch
            {
                return null;
            }
        }

        public async Task<LeilaoModel?> GetById(int id)
        {
            try
            {
                return await _leilaoDbContext
                    .Auctions
                    .Include(auction => auction.Items)
                    .FirstOrDefaultAsync(auction => auction.Id == id);
            }
            catch
            {
                return null;
            }
        }

        public async Task<List<LeilaoModel>?> GetByName(string name)
        {
            try
            {
                return await _leilaoDbContext
                    .Auctions
                    .Include(auction => auction.Items)
                    .Where(auction => auction.Name.ToLower().Contains(name.ToLower())).ToListAsync();
            }
            catch
            {
                return null;
            }
        }

        public async Task<List<LeilaoModel>?> GetCurrent()
        {
            var today = DateTime.Now;
            try
            {
                return await _leilaoDbContext
                    .Auctions
                    .Include(auction => auction.Items)
                    .Where(auction => today >= auction.Starts && today <= auction.Ends).ToListAsync();
            }
            catch
            {
                return null;
            }
        }

        public async Task<List<LeilaoModel>?> GetByDate(DateTime data)
        {
            try
            {
                return await _leilaoDbContext
                    .Auctions
                    .Include(auction => auction.Items)
                    .Where(auction => data >= auction.Starts && data <= auction.Ends).ToListAsync();
            }
            catch
            {
                return null;
            }
        }

        public async Task<List<LeilaoModel>?> GetByPeriodo(DateTime dataInicial, DateTime dataFinal)
        {
            try
            {
                return await _leilaoDbContext
                    .Auctions
                    .Include(auction => auction.Items)
                    .Where(auction => dataInicial <= auction.Starts && dataFinal >= auction.Starts || dataInicial <= auction.Ends && dataFinal >= auction.Starts).ToListAsync();
            }
            catch
            {
                return null;
            }
        }

        public async Task<List<LeilaoModel>?> GetByAtivos()
        {
            try
            {
                return await _leilaoDbContext
                    .Auctions
                    .Include(auction => auction.Items)
                    .Where(auction => auction.Starts <= DateTime.Now && auction.Ends >= DateTime.Now).ToListAsync();
            }
            catch
            {
                return null;
            }
        }

        public async Task<List<LeilaoModel>?> GetByProgramados()
        {
            try
            {
                return _leilaoDbContext
                    .Auctions
                    .Include(auction => auction.Items)
                    .Where(auction => auction.Starts > DateTime.Now).ToList();
            }
            catch
            {
                return null;
            }
        }

        public async Task<List<LeilaoModel>?> GetByEncerrados()
        {
            try
            {
                return await _leilaoDbContext
                    .Auctions
                    .Include(auction => auction.Items)
                    .Where(auction => auction.Ends < DateTime.Now).ToListAsync();
            }
            catch
            {
                return null;
            }
        }

        public async Task<LeilaoModel> InserirNovoLeilao(LeilaoModel novoLeilao)
        {
            await _leilaoDbContext.Auctions.AddAsync(novoLeilao);
            await _leilaoDbContext.SaveChangesAsync();
            return novoLeilao;
        }

        public async Task<LeilaoModel?> AlterarLeilao(int id, LeilaoModel leilao)
        {
            var result = await _leilaoDbContext.Auctions.FirstOrDefaultAsync(auction => auction.Id == id);
            if (result == null) return null;
            try
            {
                result.Name = leilao.Name;
                result.Starts = leilao.Starts;
                result.Ends = leilao.Ends;
                _leilaoDbContext.Update(result);
                await _leilaoDbContext.SaveChangesAsync();
                return result;
            }
            catch
            {
                return null;
            }
        }

        public async Task<string> DeletarLeilao(int id)
        {
            var result = await _leilaoDbContext.Auctions.FirstOrDefaultAsync(auction => auction.Id == id);
            if (result == null) return "Não encontrado";
            try
            {
                _leilaoDbContext.Auctions.Remove(result);
                await _leilaoDbContext.SaveChangesAsync();
                return "Sucesso";
            }
            catch
            {
                return "Falha";
            }

        }
    }
}
