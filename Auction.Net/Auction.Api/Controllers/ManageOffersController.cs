using Domain.Interfaces.ServicesInterfaces;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Auction.Api.Controllers
{
    public class ManageOffersController(IManageOffersService manageOffersService) : GenericsController 
    {
        private readonly IManageOffersService _manageOffersService = manageOffersService;

        [HttpGet("GetAllOffers")]
        public async Task<ActionResult<List<OfferModel>?>> GetAllOffers()
        {
            var result = await _manageOffersService.GetAllOffers();
            if (result == null) return Ok("Não encontarmos ofertas");
            return Ok(result);
        }

        [HttpGet("getAllOfferById/{idOffer:int}")]
        public async Task<ActionResult<List<OfferModel>?>> getAllOfferByIdAuction(int idOffer)
        {
            var result = await _manageOffersService.GetAllOfferByIdAuction(idOffer);
            if (result == null) return Ok("Não encontarmos ofertas");
            return Ok(result);
        }

        [HttpGet("getAllOffersByItem/{idItem:int}")]
        public async Task<ActionResult<List<OfferModel>?>> getAllOffersByItem(int idItem)
        {
            var result = await _manageOffersService.GetAllOffersByItem(idItem);
            if (result == null) return Ok("Não encontarmos ofertas");
            return Ok(result);
        }

        [HttpGet("getAllOffersByUser/{idUser:int}")]
        public async Task<ActionResult<List<OfferModel>?>> getAllOffersByUser(int idUser)
        {
            var result = await _manageOffersService.GetAllOffersByUser(idUser);
            if (result == null) return Ok("Não encontarmos ofertas");
            return Ok(result);
        }

        [HttpGet("GetOffersByUserByItem/{idUser:int}/{idItem:int}")]
        public async Task<ActionResult<List<OfferModel>?>> GetOffersByUserByItem(int idUser, int idItem)
        {
            var result = await _manageOffersService.GetOffersByUserByItem(idUser, idItem);
            if (result == null) return Ok("Não encontarmos ofertas");
            return Ok(result);
        }

        [HttpGet("GetMoreOfferByItem/{idItem:int}")]
        public async Task<ActionResult<OfferModel>?> GetMoreOfferByItem(int idItem)
        {
            var result = await _manageOffersService.GetMoreOfferByItem(idItem);
            if (result == null) return Ok("Não encontarmos os lances");
            return Ok(result);
        }

        [HttpGet("GetOffersInAuctionActive")]
        public async Task<ActionResult<List<OfferModel>?>> GetOffersInLeiloesAtivos()
        {
            var result = await _manageOffersService.GetOffersInLeiloesActive();
            return Ok(result);
        }

        [HttpGet("GetOffersInAuctionClosed")]
        public async Task<ActionResult<List<OfferModel>?>> GetOffersInLeiloesEncerrados()
        {
            var result = await _manageOffersService.GetOffersInLeiloesClosed();
            return Ok(result);
        }

    }
}