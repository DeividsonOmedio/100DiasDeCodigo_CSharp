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
        Task<List<OfferModel>?> getAllOfferById(int id);
        Task<List<OfferModel>?> getAllOffersByItem(int idItem);
        Task<List<OfferModel>?> getAllOffersByUser(int idUser);
        Task<List<OfferModel>?> GetOffersByUserByItem(int idUser, int idItem);
        Task<OfferModel?> GetMaiorOfferByItem(int idItem);
        Task<List<OfferModel>?> GetOffersInLeiloesAtivos();
        Task<List<OfferModel>?> GetOffersInLeiloesEncerrados();
    }
}
