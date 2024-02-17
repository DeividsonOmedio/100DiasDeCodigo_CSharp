using leilao.api.CasosDeUso.Ofertas.CriarOferta;
using leilao.api.Comunicacao.Resposta;
using leilao.api.Filtros;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace leilao.api.Controllers
{
    [ServiceFilter(typeof(AuteticacaoUsuarioAtributos))]
    public class OfertasController : GenericsController
    {
        [HttpPost]
        [Route("{itemId}")]
        public IActionResult CreatOffer(
            [FromRoute] int itemId,
            [FromBody] RequisicaoCriarOferta request,
            [FromServices] CriarOfertaCasosDeUso useCae)
        {
            var id = useCae.Execute(itemId, request);
            return Created(string.Empty, id);
        }
    }
}
