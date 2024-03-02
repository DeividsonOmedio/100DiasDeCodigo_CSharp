using Domain.Interfaces.RepositoryInterfaces;
using Domain.Interfaces.ServicesInterfaces;
using Entities.Entities;

namespace Domain.Services
{
    public class CreateOffersService : ICreateOffersService
    {
        private readonly ICreateOfferRepository _createOfferRepository;

        public CreateOffersService(ICreateOfferRepository createOfferRepository) =>
            _createOfferRepository = createOfferRepository;




        public Task<OfferModel> Execute(int itemId, RequestCreateOfferJson request) =>
            _createOfferRepository.Execute(itemId, request);

    }
}
