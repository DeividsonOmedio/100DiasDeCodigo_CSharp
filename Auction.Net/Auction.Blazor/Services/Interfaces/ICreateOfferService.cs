using Entities.Entities;

namespace Auction.Blazor.Services.Interfaces
{
    public interface ICreateOfferService
    {
        Task<OfferModel?> Execute(int itemId, RequestCreateOfferJson request);
    }
}
