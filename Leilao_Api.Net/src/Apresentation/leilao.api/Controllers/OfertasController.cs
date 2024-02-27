using leilao.api.CasosDeUso.Ofertas.CriarOferta;
using leilao.api.Comunicacao.Resposta;
using leilao.api.Filtros;
using leilao.api.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace leilao.api.Controllers
{
    [ServiceFilter(typeof(AuteticacaoUsuarioAtributos))]
    public class OfertasController : GenericsController
    {

        private readonly ICriarOfertaCasosDeUso _criarOfertaCasosDeUso;

        public OfertasController(ICriarOfertaCasosDeUso criarOfertaCasosDeUso)
        {
            _criarOfertaCasosDeUso = criarOfertaCasosDeUso;
        }

        [HttpPost]
        [Route("{itemId}")]
        public IActionResult CreatOffer(
            [FromRoute] int itemId,
            [FromBody] RequisicaoCriarOferta request)
        {
            // Use o _criarOfertaCasosDeUso que já foi injetado no construtor
            var idUser = User.FindFirst("id");
            var id = _criarOfertaCasosDeUso.Execute(itemId, request);
            return Created(string.Empty, id);
        }
    }
}