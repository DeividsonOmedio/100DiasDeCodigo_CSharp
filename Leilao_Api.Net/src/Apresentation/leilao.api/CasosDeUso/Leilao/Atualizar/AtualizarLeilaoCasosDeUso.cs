using leilao.api.Entities;
using leilao.api.Interfaces;

namespace leilao.api.CasosDeUso.Leilao.Atualizar
{
    public class AtualizarLeilaoCasosDeUso
    {
        private readonly ILeilaoCasosDeUso _leilaoCasosDeUso;

        public AtualizarLeilaoCasosDeUso(ILeilaoCasosDeUso leilaoCasosDeUso) => _leilaoCasosDeUso = leilaoCasosDeUso;

        public Task<List<LeilaoModel>?> GetAll() => _leilaoCasosDeUso.GetAll();

        public Task<LeilaoModel?> GetById(int id) => _leilaoCasosDeUso.GetById(id);
        public Task<List<LeilaoModel>?> GetByName(string name) => _leilaoCasosDeUso.GetByName(name);
        public Task<List<LeilaoModel>?> GetCurrent() => _leilaoCasosDeUso.GetCurrent();
        public Task<List<LeilaoModel>?> GetByDate(DateTime data) => _leilaoCasosDeUso.GetByDate(data);
        public Task<List<LeilaoModel>?> GetByPeriodo(DateTime dataInicial, DateTime dataFinal) => _leilaoCasosDeUso.GetByPeriodo(dataInicial, dataFinal);
        public Task<List<LeilaoModel>?> GetByAtivos() => _leilaoCasosDeUso.GetByAtivos();
        public Task<List<LeilaoModel>?> GetByProgramados() => _leilaoCasosDeUso.GetByProgramados();
        public Task<List<LeilaoModel>?> GetByEncerrados() => _leilaoCasosDeUso.GetByEncerrados();
        public Task<LeilaoModel>? InserirNovoLeilao(LeilaoModel novoLeilao) => _leilaoCasosDeUso.InserirNovoLeilao(novoLeilao);
        public Task<LeilaoModel?> AlterarLeilao(int id, LeilaoModel leilao) => _leilaoCasosDeUso.AlterarLeilao(id, leilao);
        public Task<string>? DeletarLeilao(int id) => _leilaoCasosDeUso.DeletarLeilao(id);


    }
}
