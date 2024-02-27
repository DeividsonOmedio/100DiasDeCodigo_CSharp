using leilao.api.CasosDeUso.Ofertas.GerenciarOfertas;
using leilao.api.Filtros;
using leilao.api.Interfaces;
using leilao.api.Repositorios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace leilao.api.Controllers
{
    [ServiceFilter(typeof(AutenticacaoAdminAtributos))]
    public class GerenciarOfertasController : GenericsController
    {
        private readonly IAtualizarGerenciarOfertasCasosDeUso _atualizarGerenciarOfertasCasosDeUso;

        public GerenciarOfertasController(IAtualizarGerenciarOfertasCasosDeUso atualizarGerenciarOfertasCasosDeUso)
        {
            _atualizarGerenciarOfertasCasosDeUso = atualizarGerenciarOfertasCasosDeUso;
        }

        [HttpGet("GetAllOffers")]
        public IActionResult GetAllOffers()
        {
            var result = _atualizarGerenciarOfertasCasosDeUso.GetAllOffers();
            if (result == null) return Ok("Não encontarmos ofertas");
            return Ok(result);
        }

        [HttpGet("getAllOfferById")]
        public IActionResult getAllOfferById(int id)
        {
            var result = _atualizarGerenciarOfertasCasosDeUso.getAllOfferById(id);
            if (result == null) return Ok("Não encontarmos ofertas");
            return Ok(result);
        }

        [HttpGet("getAllOffersByItem")]
        public IActionResult getAllOffersByItem(int idItem)
        {
            var result = _atualizarGerenciarOfertasCasosDeUso.getAllOffersByItem(idItem);
            if (result == null) return Ok("Não encontarmos ofertas");
            return Ok(result);
        }

        [HttpGet("getAllOffersByUser")]
        public IActionResult getAllOffersByUser(int idUser)
        {
            var result = _atualizarGerenciarOfertasCasosDeUso.getAllOffersByUser(idUser);
            if (result == null) return Ok("Não encontarmos ofertas");
            return Ok(result);
        }

        [HttpGet("GetOffersByUserByItem")]
        public IActionResult GetOffersByUserByItem(int idUser, int idItem)
        {
            var result = _atualizarGerenciarOfertasCasosDeUso.GetOffersByUserByItem(idUser, idItem);
            if (result == null) return Ok("Não encontarmos ofertas");
            return Ok(result);
        }

        [HttpGet("GetMaiorOfferByItem")]
        public IActionResult GetMaiorOfferByItem(int idItem)
        {
            var result = _atualizarGerenciarOfertasCasosDeUso.GetMaiorOfferByItem(idItem);
            if (result == null) return Ok("Não encontarmos os lances");
            return Ok(result);
        }

        [HttpGet("GetOffersInLeiloesAtivos")]
        public IActionResult GetOffersInLeiloesAtivos()
        {
            var result = _atualizarGerenciarOfertasCasosDeUso.GetOffersInLeiloesAtivos();
            return Ok(result);
        }

        [HttpGet("GetOffersInLeiloesEncerrados")]
        public IActionResult GetOffersInLeiloesEncerrados()
        {
            var result = _atualizarGerenciarOfertasCasosDeUso.GetOffersInLeiloesEncerrados();
            return Ok(result);
        }

    }
}
