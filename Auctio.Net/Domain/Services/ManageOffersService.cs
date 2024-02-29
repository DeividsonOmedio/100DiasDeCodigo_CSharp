using Domain.Interfaces.RepositoryInterfaces;
using Domain.Interfaces.ServicesInterfaces;
using Entities.Entities;

namespace Domain.Services
{
    public class ManageOffersService : IManageOffersService
    {
        private readonly IManageOffersRepository _manageOffersRepository;

        public ManageOffersService(IManageOffersRepository manageOffersRepository) =>
            _manageOffersRepository = manageOffersRepository;

        public Task<List<OfferModel>?> GetAllOfferByIdAuction(int id) =>
            _manageOffersRepository.GetAllOfferByIdAuction(id);

        public Task<List<OfferModel>?> GetAllOffers() =>
            _manageOffersRepository.GetAllOffers();

        public Task<List<OfferModel>?> GetAllOffersByItem(int idItem) =>
            _manageOffersRepository.GetAllOffersByItem(idItem);

        public Task<List<OfferModel>?> GetAllOffersByUser(int idUser) =>
            _manageOffersRepository.GetAllOffersByUser(idUser);

        public Task<OfferModel?> GetMoreOfferByItem(int idItem) =>
            _manageOffersRepository.GetMoreOfferByItem(idItem);

        public Task<List<OfferModel>?> GetOffersByUserByItem(int idUser, int idItem) =>
            _manageOffersRepository.GetOffersByUserByItem(idUser, idItem);

        public Task<List<OfferModel>?> GetOffersInLeiloesActive() =>
            _manageOffersRepository.GetOffersInLeiloesActive();

        public Task<List<OfferModel>?> GetOffersInLeiloesClosed() =>
            _manageOffersRepository.GetOffersInLeiloesClosed();
    }
}
