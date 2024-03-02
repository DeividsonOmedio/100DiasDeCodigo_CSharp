using Domain.Interfaces.ServicesInterfaces;
using Domain.Services;
using Entities.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Auction.Api.Controllers
{
 
    public class ItemsController : GenericsController
    {
        private readonly IUpdateItemsService _updateItemsService;

        public ItemsController(IUpdateItemsService updateItemsService) => _updateItemsService = updateItemsService;

        [HttpGet("GetAllItems")]
        [ProducesResponseType(typeof(ItemModel), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult GetAllItems()
        {
            var result = _updateItemsService.GetAllItems();
            if (result == null) return Ok("Não foram encontrados items");
            return Ok(result);
        }

        [HttpGet("ItemsByLeilao")]
        public IActionResult GetItemsByLeilao(int id)
        {
            if (id == 0) return Ok("Id do Leilao Invalido");
            var result = _updateItemsService.GetItemsByAuction(id);
            if (result == null) return NoContent();
            return Ok(result);
        }

        [HttpGet("ItemById")]
        public IActionResult GetItemById(int idItem)
        {
            if (idItem == 0) return NoContent();
            var result = _updateItemsService.GetItemsById(idItem);
            if (result == null) return Ok("Id Invalido");
            return Ok(result);
        }
        [HttpPost("CreateNewItem")]
        public IActionResult AdicionarNovoItem(int idLeilao, ItemModel novoItem)
        {
            if (idLeilao == 0) return NoContent();
            novoItem.AuctionId = idLeilao;
            var result = _updateItemsService.CreateNewItem(novoItem);
            if (result == null) return Ok("Id inválido");
            return Ok(result);
        }
        [HttpPatch("AlterarItem")]
        public IActionResult AlterarItem(ItemModel item)
        {
            if (item == null) return NoContent();
            var result = _updateItemsService.changeItem(item);
            if (result == null) return Ok("Id Invalido");
            return Ok(result);
        }
        [HttpDelete("DeletarItem")]
        public IActionResult DeletarItem(int idItem)
        {
            if (idItem == 0) return Ok("Id Invalido");
            var result = _updateItemsService.DeleteItem(idItem);
            if (result == null) return NoContent();
            return Ok(result);
        }
    }
}