using leilao.api.Entities;
using leilao.api.Repositorios;

namespace leilao.api.CasosDeUso.Usuarios
{
    public class AtualizarUsuariosCasosDeUso
    {
        private readonly LeilaoDbContext _leilaoDbContext = new();

        public List<UsuarioModel>? GetAllUsers()
        {
            try
            {
            return _leilaoDbContext
                .Users
                .ToList();
            }
            catch
            {
                return null;
            }
        }

        public UsuarioModel? GetUserById(int id)
        {
            try
            {
                return _leilaoDbContext
                    .Users
                    .FirstOrDefault(user => user.Id == id);
            }
            catch
            {
                return null;
            }
        }

        public UsuarioModel? GetByName(string name)
        {
            try
            {
            return _leilaoDbContext
                .Users
                .FirstOrDefault(user => user.Name == name);
            }
            catch
            {
                return null;
            }
        }

        public string? CreateUser(UsuarioModel usuario)
        {
            var result = _leilaoDbContext.Users.FirstOrDefault(user => user.Name.ToLower() == usuario.Name.ToLower() || user.Email.ToLower() == usuario.Email.ToLower());
            if (result != null) return "Nome ou Email já Cadastrado";
            try
            {
                _leilaoDbContext.Users.Add(usuario);
                _leilaoDbContext.SaveChanges();
                return "Created";
            }
            catch
            {
                return "Erro ao tentar fazer a solicitação";
            }
        }

        public string? AlterarNameUsuario(int id, string name)
        {
            var result = _leilaoDbContext.Users.FirstOrDefault(user => user.Id == id);
            if (result == null) return "Não encntrado";
            try
            {
                result.Name = name;
                _leilaoDbContext.Users.Update(result);
                _leilaoDbContext.SaveChanges();
                return name + "Alterado Com Sucesso";
            }
            catch
            {
                return "Erro ao tentar fazer a solicitação";
            }
        }

        public string? AlterarSenhaUsuario(int id, string senha)
        {
            var result = _leilaoDbContext.Users.FirstOrDefault(user => user.Id == id);
            if (result == null) return "Não encntrado";
            try
            {
                result.Password = senha;
                _leilaoDbContext.Users.Update(result);
                _leilaoDbContext.SaveChanges();
                return "Senha Alterada Com Sucesso";
            }
            catch
            {
                return "Erro ao tentar fazer a solicitação";
            }
        }
        public string DeleteUser(int id)
            {
            var result = _leilaoDbContext.Users.FirstOrDefault(user => user.Id == id);
            if (result == null) return "Não encntrado";
            try
            {
                _leilaoDbContext.Users.Remove(result);
                _leilaoDbContext.SaveChanges();
                return "Usuario Excluído Com Sucesso";
            }
            catch
            {
                return "Erro ao tentar fazer a solicitação";
            }
        }
    }
}