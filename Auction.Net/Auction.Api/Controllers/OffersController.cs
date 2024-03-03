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
        [HttpPost]
        [Route("{itemId}")]
        public IActionResult CreatOffer(
            [FromRoute] int itemId,
            [FromBody] RequestCreateOfferJson request)
        {
            var result = _createOfferService.Execute(itemId, request);
            return Created(string.Empty, result);
        }
    }
}