using leilao.api.Comunicacao.Resposta;
using leilao.api.Entities;
using leilao.api.Repositorios;
using leilao.api.Services;

namespace leilao.api.CasosDeUso.Ofertas.CriarOferta
{
    public class CriarOfertaCasosDeUso
    {
        private readonly UsuarioLogado _usuarioLogado;
        public CriarOfertaCasosDeUso(UsuarioLogado usuarioLogado) => _usuarioLogado = usuarioLogado;

        public int Execute(int itemId, RequisicaoCriarOferta request)
        {
            var repository = new LeilaoDbContext();

            var usuario = _usuarioLogado.Usuer();

            var oferta = new OfertaModel
            {
                CreatedOn = DateTime.Now,
                ItemId = itemId,
                Price = request.Price,
                UserId = usuario.Id
            };

            repository.Offers.Add(oferta);
            repository.SaveChanges();

            return oferta.Id;
        }
    }
}
