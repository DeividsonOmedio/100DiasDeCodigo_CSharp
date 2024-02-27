using leilao.api.Entities;

namespace leilao.api.Interfaces
{
    public interface IAtualizarGerenciarOfertasCasosDeUso
    {
        Task <List<OfertaModel>?> GetAllOffers();
        Task <List<OfertaModel>?> getAllOfferById(int id);
        Task <List<OfertaModel>?> getAllOffersByItem(int idItem);
        Task <List<OfertaModel>?> getAllOffersByUser(int idUser);
        Task <List<OfertaModel>?> GetOffersByUserByItem(int idUser, int idItem);
        Task <OfertaModel?> GetMaiorOfferByItem(int idItem);
        Task <List<OfertaModel>?> GetOffersInLeiloesAtivos();
        Task <List<OfertaModel>?> GetOffersInLeiloesEncerrados();
    }
}
