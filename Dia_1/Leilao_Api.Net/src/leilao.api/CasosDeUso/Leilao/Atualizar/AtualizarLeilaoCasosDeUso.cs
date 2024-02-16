using leilao.api.Entities;
using leilao.api.Repositorios;
using Microsoft.EntityFrameworkCore;
namespace leilao.api.CasosDeUso.Leilao.Atualizar
{
    public class AtualizarLeilaoCasosDeUso
    {
        public LeilaoModel? Execute()
        {
            var repository = new LeilaoDbContext();
            var today = new DateTime(2024, 01, 21);
            try
            {
            return repository
                .Auctions
                .Include(auction => auction.Items)
                .FirstOrDefault(auction => today >= auction.Starts && today <= auction.Ends); 
            }
            catch
            {
                return null;
            }
        }
    }
}
