using Domain.Interfaces.ServicesInterfaces;
using Entities.Entities;
using Helpers.Filters;
using Microsoft.AspNetCore.Mvc;

namespace Auction.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuctionController(IUpdateAuctionService updateAuctionService) : ControllerBase
    {
       private readonly IUpdateAuctionService _updateAuctionService = updateAuctionService;

        [HttpGet("GetAllAuction")]
        [ProducesResponseType(typeof(AuctionModel), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<ActionResult<List<AuctionModel>>> GetAllAuction()
        {
            var result = await _updateAuctionService.GetAll();
            if (result == null)
                return NoContent();
            return Ok(result);
        }
        [HttpGet("GetAuctionById/{id:int}")]
        public async Task<ActionResult<AuctionModel>> GetAuctionById(int id)
        {
            var result = await _updateAuctionService.GetById(id);
            if (result == null)
                return NoContent();
            return Ok(result);
        }
        [HttpGet("GetAuctionCurrent")]
        public async Task<ActionResult<List<AuctionModel>>> GetAuctionCurrent()
        {
            var result = await _updateAuctionService.GetCurrent();
            if (result == null)
                return NoContent();
            return Ok(result);
        }
        [HttpGet("GetAuctionByName/{name}")]
        public async Task<ActionResult<AuctionModel>?> GetAuctionByName(string name)
        {
            var result = await _updateAuctionService.GetByName(name);
            if (result == null)
                return NoContent();

            return Ok(result);
        }
        [HttpGet("GetByDate")]
        public IActionResult GetByDate(DateTime data)
        {
            var result = _updateAuctionService.GetByDate(data);
            if (result == null)
                return Ok("Não há Leilões nessa data");
            return Ok(result);
        }

        [HttpGet("GetByPeriod")]
        public IActionResult GetByPeriod(DateTime dataInicial, DateTime dataFinal)
        {
            var result = _updateAuctionService.GetByPeriod(dataInicial, dataFinal);
            if (result == null)
                return Ok("Não há Leilões neste período");
            return Ok(result);
        }

        [HttpGet("GetByProgrammed")]
        public IActionResult GetByProgrammed()
        {
            var result = _updateAuctionService.GetByProgrammed();
            if (result == null)
                return Ok("Não há Leilões Ativos No Momento");
            return Ok(result);
        }

        [HttpGet("GetByClosed")]
        public IActionResult GetByClosed()
        {
            var result = _updateAuctionService.GetByClosed();
            if (result == null)
                return Ok("Não há Leilões Ativos No Momento");
            return Ok(result);
        }
        [ServiceFilter(typeof(AuthenticationGenericsAttributes))]
        [HttpPost("CreateAuction")]
        public async Task<ActionResult<AuctionModel>> CreateAuction(AuctionModel newAuction)
        {
            var result = await _updateAuctionService.CreateNewAuction(newAuction);
            if (result == null)
                return NoContent();
            return Ok(result);
        }
        [ServiceFilter(typeof(AuthenticationGenericsAttributes))]
        [HttpPut("ChangeDataAuction")]
        public IActionResult ChangeDataAuction(int id, AuctionModel leilao)
        {
            var result = _updateAuctionService.ChangeAuction(id, leilao);
            if (result == null) return NotFound("Não encontramos o ID informado");
            return Ok(result);
        }
        [ServiceFilter(typeof(AuthenticationGenericsAttributes))]
        [HttpPut("DeleteAuction")]
        public IActionResult DeleteAuction(int id)
        {
            var result = _updateAuctionService.DeleteAuction(id);
            if (result.ToString() == "Não encontrado") return NotFound("Não encontramos o ID informado");
            else if (result.ToString() == "Falha") return Ok("Falha ao tentar a operação");
            return Ok("Leilão excluido com sucesso!");
        }
    }
}
