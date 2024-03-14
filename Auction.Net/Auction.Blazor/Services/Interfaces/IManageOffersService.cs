using Entities.Entities;

namespace Auction.Blazor.Services.Interfaces
{
    public interface IManageOffersService
    {
        Task<IEnumerable<OfferModel>?> GetAllOffers();
        Task<IEnumerable<OfferModel>?> GetAllOfferByIdAuction(int idAuction);
        Task<IEnumerable<OfferModel>?> GetAllOffersByItem(int idItem);
        Task<IEnumerable<OfferModel>?> GetAllOffersByUser(int idUser);
        Task<IEnumerable<OfferModel>?> GetOffersByUserByItem(int idUser, int idItem);
        Task<IEnumerable<OfferModel>?> GetOffersInAuctionActive();
        Task<IEnumerable<OfferModel>?> GetOffersInAuctionClosed();
        Task<OfferModel?> GetMoreOfferByItem(int idItem);
    }
}
