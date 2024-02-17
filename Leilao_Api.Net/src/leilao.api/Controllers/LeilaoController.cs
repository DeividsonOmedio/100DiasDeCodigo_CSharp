using leilao.api.CasosDeUso.Leilao.Atualizar;
using leilao.api.Entities;
using Microsoft.AspNetCore.Mvc;

namespace leilao.api.Controllers
{
    public class LeilaoController : GenericsController
    {
        [HttpGet]
        [ProducesResponseType(typeof(LeilaoModel), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult GetCurrentAuction()
        {
            var useCase = new AtualizarLeilaoCasosDeUso();
            var result = useCase.Execute();
            if (result == null)
                return NoContent();

            return Ok(result);
        }
    }
}
