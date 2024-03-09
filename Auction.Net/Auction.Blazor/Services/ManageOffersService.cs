using Auction.Blazor.Services.Interfaces;
using Entities.Entities;

namespace Auction.Blazor.Services
{
    public class ManageOffersService : IManageOffersService
    {
        public Task<List<OfferModel>?> GetAllOfferByIdAuction(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<OfferModel>?> GetAllOffers()
        {
            throw new NotImplementedException();
        }

        public Task<List<OfferModel>?> GetAllOffersByItem(int idItem)
        {
            throw new NotImplementedException();
        }

        public Task<List<OfferModel>?> GetAllOffersByUser(int idUser)
        {
            throw new NotImplementedException();
        }

        public Task<OfferModel?> GetMoreOfferByItem(int idItem)
        {
            throw new NotImplementedException();
        }

        public Task<List<OfferModel>?> GetOffersByUserByItem(int idUser, int idItem)
        {
            throw new NotImplementedException();
        }

        public Task<List<OfferModel>?> GetOffersInLeiloesActive()
        {
            throw new NotImplementedException();
        }

        public Task<List<OfferModel>?> GetOffersInLeiloesClosed()
        {
            throw new NotImplementedException();
        }
    }
}
