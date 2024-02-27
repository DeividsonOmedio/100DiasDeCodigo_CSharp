using leilao.api.CasosDeUso.Items;
using leilao.api.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace leilao.api.Controllers
{
    public class ItemsController : GenericsController
    {
        private readonly AtualizarItemsCasosDeUso _atualizarItemsCasosDeUso = new();

        [HttpGet("GetAllItems")]
        [ProducesResponseType(typeof(ItemModel), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult GetAllItems()
        {
            var result = _atualizarItemsCasosDeUso.GetAllItems();
            if (result == null) return Ok("Não foram encontrados items");
            return Ok(result);
        }

        [HttpGet("ItemsByLeilao")]
        public IActionResult GetItemsByLeilao(int id)
        {
            if (id == 0) return Ok("Id do Leilao Invalido");
            var result = _atualizarItemsCasosDeUso.GetItemsByLeilao(id);
            if (result == null) return NoContent();
            return Ok(result);
        }

        [HttpGet("ItemById")]
        public IActionResult GetItemById(int idItem)
        {
            if (idItem == 0) return NoContent();
            var result = _atualizarItemsCasosDeUso.GetItemsById(idItem);
            if (result == null) return Ok("Id Invalido");
            return Ok(result);
        }
        [HttpPost("CreateNewItem")]
        public IActionResult AdicionarNovoItem(int idLeilao, ItemModel novoItem)
        {
            if (idLeilao == 0) return NoContent();
            novoItem.AuctionId = idLeilao;
            var result = _atualizarItemsCasosDeUso.CreateNewItem(novoItem);
            if (result == null) return Ok("Id inválido");
            return Ok(result);
        }
        [HttpPatch("AlterarItem")]
        public IActionResult AlterarItem(ItemModel item)
        {
            if (item == null) return NoContent();
            var result = _atualizarItemsCasosDeUso.AlterarItem(item);
            if (result == null) return Ok("Id Invalido");
            return Ok(result);
        }
        [HttpDelete("DeletarItem")]
        public IActionResult DeletarItem(int idItem)
        {
            if (idItem == 0) return Ok("Id Invalido");
            var result = _atualizarItemsCasosDeUso.DeleteItem(idItem);
            if (result == null) return NoContent();
            return Ok(result);
        }
    }
}