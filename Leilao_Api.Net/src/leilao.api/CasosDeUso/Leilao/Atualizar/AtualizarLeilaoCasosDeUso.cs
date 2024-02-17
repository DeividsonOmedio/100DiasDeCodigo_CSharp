using leilao.api.Entities;
using leilao.api.Repositorios;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
namespace leilao.api.CasosDeUso.Leilao.Atualizar
{
    public class AtualizarLeilaoCasosDeUso
    {
        private readonly LeilaoDbContext _leilaoDbContext = new();


        public List<LeilaoModel>? ExecuteAll()
        {
            try
            {
                return _leilaoDbContext
                    .Auctions
                    .Include(auction => auction.Items)
                    .ToList();
            }
            catch
            {
                return null;
            }
        }
        public LeilaoModel? ExecuteById(int id)
        {
            try
            {
                return _leilaoDbContext
                    .Auctions
                    .Include(auction => auction.Items)
                    .FirstOrDefault(auction => auction.Id == id);
            }
            catch
            {
                return null;
            }
        }
        public List<LeilaoModel>? ExecuteByName(string name)
        {
            try
            {
                return _leilaoDbContext
                    .Auctions
                    .Include(auction => auction.Items)
                    .Where(auction => auction.Name.ToLower().Contains(name.ToLower())).ToList();
            }
            catch
            {
                return null;
            }
        }
        public List<LeilaoModel>? ExecuteCurrent()
        {
            var today = DateTime.Now;
            try
            {
                return _leilaoDbContext
                    .Auctions
                    .Include(auction => auction.Items)
                    .Where(auction => today >= auction.Starts && today <= auction.Ends).ToList();
            }
            catch
            {
                return null;
            }
        }
        public List<LeilaoModel>? ExecuteByDate(DateTime data)
        {
            try
            {
                return _leilaoDbContext
                    .Auctions
                    .Include(auction => auction.Items)
                    .Where(auction => data >= auction.Starts && data <= auction.Ends).ToList();
            }
            catch
            {
                return null;
            }
        }
        public List<LeilaoModel>? ExecuteByPeriodo(DateTime dataInicial, DateTime dataFinal)
        {
            try
            {
                return _leilaoDbContext
                    .Auctions
                    .Include(auction => auction.Items)
                    .Where(auction => dataInicial <= auction.Starts && dataFinal >= auction.Starts || dataInicial <= auction.Ends && dataFinal >= auction.Starts).ToList();
            }
            catch
            {
                return null;
            }
        }
        public LeilaoModel InserirNovoLeilao(LeilaoModel novoLeilao)
        {
            _leilaoDbContext.Auctions.Add(novoLeilao);
            _leilaoDbContext.SaveChanges();
            return novoLeilao;
        }
        public LeilaoModel? AlterarLeilao(int id, LeilaoModel leilao)
        {
            var result = _leilaoDbContext.Auctions.FirstOrDefault(auction => auction.Id == id);
            if (result == null) return null;
            try
            {
                result.Name = leilao.Name;
                result.Starts = leilao.Starts;
                result.Ends = leilao.Ends;
                _leilaoDbContext.Update(result);
                _leilaoDbContext.SaveChanges();
                return result;
            }
            catch
            {
                return null;
            }
        }
        public string DeletarLeilao(int id)
        {
            var result = _leilaoDbContext.Auctions.FirstOrDefault(auction => auction.Id == id);
            if (result == null) return "Não encontrado";
            try
            {
                _leilaoDbContext.Auctions.Remove(result);
                _leilaoDbContext.SaveChanges();
                return "Sucesso";
            }
            catch
            {
                return "Falha";
            }

        }

    }
}
