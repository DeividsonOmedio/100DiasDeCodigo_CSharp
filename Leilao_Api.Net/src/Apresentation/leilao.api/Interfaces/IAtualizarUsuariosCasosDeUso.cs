using leilao.api.Entities;

namespace leilao.api.Interfaces
{
    public interface IAtualizarUsuariosCasosDeUso
    {
        Task<List<UsuarioModel>?> GetAllUsers();
        Task<UsuarioModel?> GetUserById(int id);
        Task<List<UsuarioModel>?> GetByName(string name);
        Task<UsuarioModel?> GetByEmail(string email);
        Task<string?> CreateUser(UsuarioModel usuario);
        Task<string?> AlterarNameUsuario(int id, string name);
        Task<string?> AlterarEmailUsuario(int id, string email);
        Task<string?> AlterarSenhaUsuario(int id, string senha);
        Task<string> DeleteUser(int id);
    }
}
