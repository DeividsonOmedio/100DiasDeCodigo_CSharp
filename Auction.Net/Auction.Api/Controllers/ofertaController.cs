using Domain.Interfaces.ServicesInterfaces;
using Entities.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Auction.Api.Controllers
{
    
    public class ofertaController(ICreateOfferService createOfferService) : GenericsController
    {
        private readonly ICreateOfferService _createOfferService = createOfferService;

        [HttpPost("createoffer/{itemId:int}")]
        public IActionResult CreatOffer(int itemId, RequestCreateOfferJson request)
        {
            var result = _createOfferService.Execute(itemId, request);
            return Created(string.Empty, result);
        }
    }
}
