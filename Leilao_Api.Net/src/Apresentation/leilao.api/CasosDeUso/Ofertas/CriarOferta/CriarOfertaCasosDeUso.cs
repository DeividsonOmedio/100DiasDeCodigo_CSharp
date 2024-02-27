using leilao.api.Comunicacao.Resposta;
using leilao.api.Entities;
using leilao.api.Interfaces;
using leilao.api.Repositorios;
using leilao.api.Services;

namespace leilao.api.CasosDeUso.Ofertas.CriarOferta
{
    public class CriarOfertaCasosDeUso : ICriarOfertaCasosDeUso
    {
        private readonly UsuarioLogado _usuarioLogado;
        private readonly IOfertas _repository;
        public CriarOfertaCasosDeUso(UsuarioLogado usuarioLogado, IOfertas repository)
        {
            _usuarioLogado = usuarioLogado;
            _repository = repository;
        }

        public async Task<OfertaModel> Execute(int itemId, RequisicaoCriarOferta request)
        {
            var repository = new LeilaoDbContext();

            var usuario = _usuarioLogado.ObterUsuario();

            var oferta = new OfertaModel
            {
                CreatedOn = DateTime.Now,
                ItemId = itemId,
                Price = request.Price,
                UserId = usuario.Id
            };

            _repository.Add(oferta);

            return oferta;
        }
    }
}
