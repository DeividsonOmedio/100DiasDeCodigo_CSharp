using leilao.api.Entities;

namespace leilao.api.Interfaces
{
    public interface ILeilaoCasosDeUso
    {
        Task<List<LeilaoModel>?> GetAll();
        Task<LeilaoModel?> GetById(int id);
        Task<List<LeilaoModel>?> GetByName(string name);
        Task<List<LeilaoModel>?> GetCurrent();
        Task<List<LeilaoModel>?> GetByDate(DateTime data);
        Task<List<LeilaoModel>?> GetByPeriodo(DateTime dataInicial, DateTime dataFinal);
        Task<List<LeilaoModel>?> GetByAtivos();
        Task<List<LeilaoModel>?> GetByProgramados();
        Task<List<LeilaoModel>?> GetByEncerrados();
        Task<LeilaoModel> InserirNovoLeilao(LeilaoModel novoLeilao);
        Task<LeilaoModel?> AlterarLeilao(int id, LeilaoModel leilao);
        Task<string> DeletarLeilao(int id);
    }
}
