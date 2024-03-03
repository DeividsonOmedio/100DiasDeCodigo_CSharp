using Domain.Interfaces.RepositoryInterfaces;
using Domain.Interfaces.ServicesInterfaces;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class CreateOfferService(ICreateOfferRepository createOfferRepository) : ICreateOfferService
    {
        private readonly ICreateOfferRepository _createOfferRepository = createOfferRepository;

        public Task<OfferModel> Execute(int itemId, RequestCreateOfferJson request) =>
            _createOfferRepository.Execute(itemId, request);
    }
}
