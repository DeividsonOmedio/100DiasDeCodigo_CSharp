using Domain.Interfaces.ServicesInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace Auction.Api.Controllers
{
    public class ManageOffersController : GenericsController 
    {
        private readonly IManageOffersService _manageOffersService;
        public ManageOffersController(IManageOffersService manageOffersService) => _manageOffersService = manageOffersService;

        [HttpGet("GetAllOffers")]
        public IActionResult GetAllOffers()
        {
            var result = _manageOffersService.GetAllOffers();
            if (result == null) return Ok("Não encontarmos ofertas");
            return Ok(result);
        }

        [HttpGet("getAllOfferById/({idOffer:int})")]
        public IActionResult getAllOfferByIdAuction(int idOffer)
        {
            var result = _manageOffersService.GetAllOfferByIdAuction(idOffer);
            if (result == null) return Ok("Não encontarmos ofertas");
            return Ok(result);
        }

        [HttpGet("getAllOffersByItem/({idItem:int})")]
        public IActionResult getAllOffersByItem(int idItem)
        {
            var result = _manageOffersService.GetAllOffersByItem(idItem);
            if (result == null) return Ok("Não encontarmos ofertas");
            return Ok(result);
        }

        [HttpGet("getAllOffersByUser/({idUser:int})")]
        public IActionResult getAllOffersByUser(int idUser)
        {
            var result = _manageOffersService.GetAllOffersByUser(idUser);
            if (result == null) return Ok("Não encontarmos ofertas");
            return Ok(result);
        }

        [HttpGet("GetOffersByUserByItem/({idUser:int})/({idItem:int})")]
        public IActionResult GetOffersByUserByItem(int idUser, int idItem)
        {
            var result = _manageOffersService.GetOffersByUserByItem(idUser, idItem);
            if (result == null) return Ok("Não encontarmos ofertas");
            return Ok(result);
        }

        [HttpGet("GetMoreOfferByItem/({idItem:int})")]
        public IActionResult GetMoreOfferByItem(int idItem)
        {
            var result = _manageOffersService.GetMoreOfferByItem(idItem);
            if (result == null) return Ok("Não encontarmos os lances");
            return Ok(result);
        }

        [HttpGet("GetOffersInAuctionActive")]
        public IActionResult GetOffersInLeiloesAtivos()
        {
            var result = _manageOffersService.GetOffersInLeiloesActive();
            return Ok(result);
        }

        [HttpGet("GetOffersInAuctionClosed")]
        public IActionResult GetOffersInLeiloesEncerrados()
        {
            var result = _manageOffersService.GetOffersInLeiloesClosed();
            return Ok(result);
        }

    }
}