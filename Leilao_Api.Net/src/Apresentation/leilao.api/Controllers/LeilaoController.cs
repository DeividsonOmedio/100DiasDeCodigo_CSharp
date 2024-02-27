using leilao.api.CasosDeUso.Leilao.Atualizar;
using leilao.api.Entities;
using leilao.api.Interfaces;
using leilao.api.Repositorios;
using Microsoft.AspNetCore.Mvc;

namespace leilao.api.Controllers
{
    public class LeilaoController : GenericsController
    {

        private readonly AtualizarLeilaoCasosDeUso _useCase;

        public LeilaoController(AtualizarLeilaoCasosDeUso useCase)
        {
            _useCase = useCase;
        }

        [HttpGet("GetAllAuction")]
        [ProducesResponseType(typeof(LeilaoModel), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult GetAllAuction()
        {
            var result = _useCase.GetAll();
            if (result == null)
                return NoContent();

            return Ok(result);
        }
        [HttpGet("AuctionById")]
        public IActionResult GetAuctionById(int id)
        {
            var result = _useCase.GetById(id);
            if (result == null)
                return NoContent();

            return Ok(result);
        }
        [HttpGet("AuctionByName")]
        public IActionResult GetAuctionByName(string name)
        {
            var result = _useCase.GetByName(name);
            if (result == null)
                return NoContent();

            return Ok(result);
        }
        [HttpGet("LeilõesCorrentes")]
        public IActionResult GetCurrentAuction()
        {
            var result = _useCase.GetCurrent();
            if (result == null)
                return NoContent();

            return Ok(result);
        }
        [HttpGet("BuscaPorData")]
        public IActionResult GetAuctionByDate(DateTime data)
        {
            var result = _useCase.GetByDate(data);
            if (result == null)
                return Ok("Não há Leilões nessa data");

            return Ok(result);
        }

        [HttpGet("BuscaPorPeriodo")]
        public IActionResult GetAuctionByPeriodo(DateTime dataInicial, DateTime dataFinal)
        {
            var result = _useCase.GetByPeriodo(dataInicial, dataFinal);
            if (result == null)
                return Ok("Não há Leilões neste período");

            return Ok(result);
        }

        [HttpGet("GetByAtivos")]
        public IActionResult GetByAtivos()
        {
            var result = _useCase.GetByAtivos();
            if (result == null)
                return Ok("Não há Leilões Ativos No Momento");

            return Ok(result);
        }

        [HttpGet("GetByProgramados")]
        public IActionResult GetByProgramados()
        {
            var result = _useCase.GetByProgramados();
            if (result == null)
                return Ok("Não há Leilões Ativos No Momento");

            return Ok(result);
        }

        [HttpGet("GetByEncerrados")]
        public IActionResult GetByEncerrados()
        {
            var result = _useCase.GetByEncerrados();
            if (result == null)
                return Ok("Não há Leilões Ativos No Momento");

            return Ok(result);
        }

        [HttpPost("NovoLeilao")]
        public IActionResult PostItems(string Nome, DateTime start, DateTime end)
        {
            LeilaoModel novoLeilao = new LeilaoModel();
            novoLeilao.Name = Nome;
            novoLeilao.Starts = start;
            novoLeilao.Ends = end;
            var result = _useCase.InserirNovoLeilao(novoLeilao);
            if (result == null)
                return NoContent();

            return Ok(result);
        }
        [HttpPut("AlterarDadosLeilao")]
        public IActionResult AlterarDadosLeilao(int id, LeilaoModel leilao)
        {
            var result = _useCase.AlterarLeilao(id, leilao);
            if (result == null) return NotFound("Não encontramos o ID informado");
            return Ok(result);
        }
        [HttpPut("DeletarLeilao")]
        public IActionResult DeletarLeilao(int id)
        {
            var result = _useCase.DeletarLeilao(id);
            if (result.ToString() == "Não encontrado") return NotFound("Não encontramos o ID informado");
            else if (result.ToString() == "Falha") return Ok("Falha ao tentar a operação");
            return Ok("Leilão excluido com sucesso!");
        }
    }
}
