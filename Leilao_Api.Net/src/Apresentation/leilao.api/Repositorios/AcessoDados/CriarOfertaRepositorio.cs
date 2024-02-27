using leilao.api.Entities;
using leilao.api.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace leilao.api.Repositorios.AcessoDados
{
    public class CriarOfertaRepositorio : IOfertas
    {
        private readonly LeilaoDbContext _leilaoDbContext;

        public CriarOfertaRepositorio(LeilaoDbContext leilaoDbContext) => _leilaoDbContext = leilaoDbContext;


        public async void Add(OfertaModel oferta)
        {
            _leilaoDbContext.Offers.Add(oferta);
            await _leilaoDbContext.SaveChangesAsync();

        }
    }
}
