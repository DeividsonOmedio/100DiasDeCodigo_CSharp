using Domain.Interfaces.RepositoryInterfaces;
using Domain.Interfaces.ServicesInterfaces;
using Entities.Entities;
using Helpers.Filters;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Auction.Api.Controllers
{

    public class OffersController(ICreateOfferService createOfferService) : GenericsController
    {

        private readonly ICreateOfferService _createOfferService = createOfferService;

        [ServiceFilter(typeof(AuthenticationUserAttributes))]
        [HttpPost("createoffer/{itemId:int}")]
        public async Task<ActionResult<OfferModel>> CreatOffer(int itemId, RequestCreateOfferJson request)
        {
            var result = await _createOfferService.Execute(itemId, request);
            return Ok(result);
        }
    }
}