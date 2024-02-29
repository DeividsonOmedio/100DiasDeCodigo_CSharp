using Domain.Interfaces.RepositoryInterfaces;
using Entities.Entities;
using Infra.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repository
{
    public class ManageOffersRepository : IManageOffersRepository
    {
        private readonly AuctionDbContext _auctionDbContext;

        public ManageOffersRepository(AuctionDbContext auctionDbContext) => _auctionDbContext = auctionDbContext;
      
        public async Task<List<OfferModel>?> GetAllOffers()
        {
            try
            {
                return await _auctionDbContext
                    .Offers
                    .ToListAsync();
            }
            catch
            {
                return null;
            }
        }
        public async Task<List<OfferModel>?> GetAllOfferByIdAuction(int id)
        {
            try
            {
                return await _auctionDbContext
                    .Offers
                    .Where(offer => offer.Id == id)
                    .ToListAsync();
            }
            catch
            {
                return null;
            }
        }


        public async Task<List<OfferModel>?> GetAllOffersByItem(int idItem)
        {
            try
            {
                return await _auctionDbContext
                    .Offers
                    .Where(offer => offer.ItemId == idItem)
                    .ToListAsync();
            }
            catch
            {
                return null;
            }
        }

        public async Task<List<OfferModel>?> GetAllOffersByUser(int idUser)
        {
            try
            {
                return await _auctionDbContext
                    .Offers
                    .Where(offer => offer.UserId == idUser)
                    .ToListAsync();
            }
            catch
            {
                return null;
            }
        }

        public async Task<List<OfferModel>?> GetOffersByUserByItem(int idUser, int idItem)
        {
            try
            {
                return await _auctionDbContext
                    .Offers
                    .Where(offer => offer.UserId == idUser && offer.ItemId == idItem)
                    .ToListAsync();
            }
            catch
            {
                return null;
            }
        }

        public async Task<OfferModel?> GetMoreOfferByItem(int idItem)
        {
            try
            {
                using (var banco = _auctionDbContext)
                {
                    return await
                        (
                        from o in banco.Offers
                        where o.ItemId == idItem
                        orderby -((double)o.Price)
                        select o).AsNoTracking().FirstOrDefaultAsync();
                }
            }
            catch
            {
                return null;
            }
        }

        public async Task<List<OfferModel>?> GetOffersInLeiloesActive()
        {
            try
            {
                using (var banco = _auctionDbContext)
                {
                    return await
                        (from o in banco.Offers
                         join i in banco.Items on o.ItemId equals i.Id
                         join l in banco.Auctions on i.AuctionId equals l.Id
                         where l.Starts <= DateTime.Now && l.Ends >= DateTime.Now
                         select o).AsNoTracking().ToListAsync();
                }
            }
            catch
            {
                return null;
            }
        }

        public async Task<List<OfferModel>?> GetOffersInLeiloesClosed()
        {

            try
            {
                using (var banco = _auctionDbContext)
                {
                    return await
                        (from o in banco.Offers
                         join i in banco.Items on o.ItemId equals i.Id
                         join l in banco.Auctions on i.AuctionId equals l.Id
                         where l.Ends < DateTime.Now
                         select o).AsNoTracking().ToListAsync();
                }
            }
            catch
            {
                return null;
            }
        }
    }
}
