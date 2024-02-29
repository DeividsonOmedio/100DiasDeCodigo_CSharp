using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.RepositoryInterfaces
{
    public interface IManageOffersRepository
    {
        Task<List<OfferModel>?> GetAllOffers();
        Task<List<OfferModel>?> GetAllOfferByIdAuction(int id);
        Task<List<OfferModel>?> GetAllOffersByItem(int idItem);
        Task<List<OfferModel>?> GetAllOffersByUser(int idUser);
        Task<List<OfferModel>?> GetOffersByUserByItem(int idUser, int idItem);
        Task<OfferModel?> GetMoreOfferByItem(int idItem);
        Task<List<OfferModel>?> GetOffersInLeiloesActive();
        Task<List<OfferModel>?> GetOffersInLeiloesClosed();
    }
}
