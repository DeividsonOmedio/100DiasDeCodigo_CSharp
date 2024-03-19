using Domain.Interfaces;
using Domain.Interfaces.RepositoryInterfaces;
using Entities.Entities;
using Infra.Configurations;

namespace Infra.Repository
{
    public class CreateOfferRepository(ILoggedUser userLogged, AuctionDbContext auctionDbContext) : ICreateOfferRepository
    {
        private readonly ILoggedUser _userLogged = userLogged;
        private readonly AuctionDbContext _auctionDbContext = auctionDbContext;

        public async Task<OfferModel> Execute(int itemId, RequestCreateOfferJson request)
        {
            var usuario = _userLogged.User();

            var offer = new OfferModel
            {
                CreatedOn = DateTime.Now,
                ItemId = itemId,
                Price = request.Price,
                UserId = usuario.Id
            };
            await _auctionDbContext.Offers.AddAsync(offer);
            await _auctionDbContext.SaveChangesAsync();

            return offer;
        }
   
     
    }
}
