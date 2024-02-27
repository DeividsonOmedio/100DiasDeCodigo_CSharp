using leilao.api.Comunicacao.Resposta;
using leilao.api.Entities;

namespace leilao.api.Interfaces
{
    public interface ICriarOfertaCasosDeUso
    {
        Task<OfertaModel> Execute(int itemId, RequisicaoCriarOferta request);
    }
}
