using leilao.api.CasosDeUso.Leilao.Atualizar;
using leilao.api.Entities;
using leilao.api.Repositorios;
using Microsoft.AspNetCore.Mvc;

namespace leilao.api.Controllers
{
    public class LeilaoController : GenericsController
    {
        [HttpGet]
        [ProducesResponseType(typeof(LeilaoModel), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult GetAllAuction()
        {
            var useCase = new AtualizarLeilaoCasosDeUso();
            var result = useCase.ExecuteAll();
            if (result == null)
                return NoContent();

            return Ok(result);
        }
        [HttpGet("AuctionById")]
        public IActionResult GetAuctionById(int id)
        {
            var useCase = new AtualizarLeilaoCasosDeUso();
            var result = useCase.ExecuteById(id);
            if (result == null)
                return NoContent();

            return Ok(result);
        }
        [HttpGet("AuctionByName")]
        public IActionResult GetAuctionByName(string name)
        {
            var useCase = new AtualizarLeilaoCasosDeUso();
            var result = useCase.ExecuteByName(name);
            if (result == null)
                return NoContent();

            return Ok(result);
        }
        [HttpGet("Leilões Correntes")]
        public IActionResult GetCurrentAuction()
        {
            var useCase = new AtualizarLeilaoCasosDeUso();
            var result = useCase.ExecuteCurrent();
            if (result == null)
                return NoContent();

            return Ok(result);
        }
        [HttpGet("Busca Por Data")]
        public IActionResult GetAuctionByDate(DateTime data)
        {
            var useCase = new AtualizarLeilaoCasosDeUso();
            var result = useCase.ExecuteByDate(data);
            if (result == null)
                return Ok("Não há Leilões nessa data");

            return Ok(result);
        }
        [HttpGet("Busca Por Periodo")]
        public IActionResult GetAuctionByPeriodo(DateTime dataInicial, DateTime dataFinal)
        {
            var useCase = new AtualizarLeilaoCasosDeUso();
            var result = useCase.ExecuteByPeriodo(dataInicial, dataFinal);
            if (result == null)
                return Ok("Não há Leilões neste período");

            return Ok(result);
        }

        [HttpPost("NovoLeilao")]
        public IActionResult PostItems(string Nome, DateTime start, DateTime end)
        {
            LeilaoModel novoLeilao = new LeilaoModel();
            novoLeilao.Name = Nome;
            novoLeilao.Starts = start;
            novoLeilao.Ends = end;
            var useCase = new AtualizarLeilaoCasosDeUso();
            var result = useCase.InserirNovoLeilao(novoLeilao);
            if (result == null)
                return NoContent();

            return Ok(result);
        }
        [HttpPut("AlterarDadosLeilao")]
        public IActionResult AlterarDadosLeilao(int id, LeilaoModel leilao)
        {
            var useCase = new AtualizarLeilaoCasosDeUso();
            var result = useCase.AlterarLeilao(id, leilao);
            if (result == null) return NotFound("Não encontramos o ID informado");
            return Ok(result);
        }
        [HttpPut("DeletarLeilao")]
        public IActionResult DeletarLeilao(int id)
        {
            var useCase = new AtualizarLeilaoCasosDeUso();
            var result = useCase.DeletarLeilao(id);
            if (result == "Não encontrado") return NotFound("Não encontramos o ID informado");
            else if (result == "Falha") return Ok("Falha ao tentar a operação");
            return Ok("Leilão excluido com sucesso!");
        }
    }
}
