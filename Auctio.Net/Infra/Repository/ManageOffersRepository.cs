using Domain.Interfaces.RepositoryInterfaces;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repository
{
    public class ManageOffersRepository : IManageOffersRepository
    {
        public Task<List<OfferModel>?> getAllOfferById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<OfferModel>?> GetAllOffers()
        {
            throw new NotImplementedException();
        }

        public Task<List<OfferModel>?> getAllOffersByItem(int idItem)
        {
            throw new NotImplementedException();
        }

        public Task<List<OfferModel>?> getAllOffersByUser(int idUser)
        {
            throw new NotImplementedException();
        }

        public Task<OfferModel?> GetMaiorOfferByItem(int idItem)
        {
            throw new NotImplementedException();
        }

        public Task<List<OfferModel>?> GetOffersByUserByItem(int idUser, int idItem)
        {
            throw new NotImplementedException();
        }

        public Task<List<OfferModel>?> GetOffersInLeiloesAtivos()
        {
            throw new NotImplementedException();
        }

        public Task<List<OfferModel>?> GetOffersInLeiloesEncerrados()
        {
            throw new NotImplementedException();
        }
    }
}
