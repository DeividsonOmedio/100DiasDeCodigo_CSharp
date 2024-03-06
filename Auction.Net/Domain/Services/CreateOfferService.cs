using Domain.Interfaces.RepositoryInterfaces;
using Domain.Interfaces.ServicesInterfaces;
using Entities.Entities;

namespace Domain.Services
{
    public class CreateOfferService(ICreateOfferRepository createOfferRepository) : ICreateOfferService
    {
        private readonly ICreateOfferRepository _createOfferRepository = createOfferRepository;

        public Task<OfferModel> Execute(int itemId, RequestCreateOfferJson request) =>
            _createOfferRepository.Execute(itemId, request);
    }
}
