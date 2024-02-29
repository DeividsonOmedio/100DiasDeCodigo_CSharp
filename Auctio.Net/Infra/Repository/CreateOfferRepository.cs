using Domain.Interfaces.RepositoryInterfaces;
using Entities.Entities;
using Infra.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repository
{
    public class CreateOfferRepository : ICreateOfferRepository
    {
        private readonly AuctionDbContext _auctionDbContext;

        public CreateOfferRepository(AuctionDbContext auctionDbContext) => _auctionDbContext = auctionDbContext;

        public async Task<OfferModel?> Add(OfferModel offer)
        {
            try
            {
                var result = _auctionDbContext.Offers.AddAsync(offer);
                var response = await _auctionDbContext.SaveChangesAsync();
                return offer;
            }
            catch
            {
                return null;
            }
        }
    }
}
