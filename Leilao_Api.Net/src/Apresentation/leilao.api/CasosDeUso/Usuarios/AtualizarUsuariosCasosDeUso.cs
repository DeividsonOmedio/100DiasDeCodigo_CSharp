using leilao.api.Entities;
using leilao.api.Interfaces;
using leilao.api.Repositorios;
using Microsoft.EntityFrameworkCore;

namespace leilao.api.CasosDeUso.Usuarios
{
    public class AtualizarUsuariosCasosDeUso : IAtualizarUsuariosCasosDeUso
    {
        private readonly LeilaoDbContext _leilaoDbContext;

        public AtualizarUsuariosCasosDeUso(LeilaoDbContext leilaoDbContext)
        {
            _leilaoDbContext = leilaoDbContext;
        }

        public async Task<List<UsuarioModel>?> GetAllUsers()
        {
            try
            {
                return await _leilaoDbContext.Users.ToListAsync();
            }
            catch
            {
                return null;
            }
        }

        public async Task<UsuarioModel?> GetUserById(int id)
        {
            try
            {
                return await _leilaoDbContext.Users.FirstOrDefaultAsync(user => user.Id == id);
            }
            catch
            {
                return null;
            }
        }

        public async Task<List<UsuarioModel>?> GetByName(string name)
        {
            try
            {
                return await _leilaoDbContext.Users
                    .Where(user => user.Name.ToLower().Contains(name.ToLower()))
                    .ToListAsync();
            }
            catch
            {
                return null;
            }
        }

        public async Task<UsuarioModel?> GetByEmail(string email)
        {
            try
            {
                return await _leilaoDbContext.Users
                    .FirstOrDefaultAsync(user => user.Email.ToLower() == (email.ToLower()));
            }
            catch
            {
                return null;
            }
        }

        public async Task<string?> CreateUser(UsuarioModel usuario)
        {
            var result = await _leilaoDbContext.Users.FirstOrDefaultAsync(user =>
                user.Name.ToLower() == usuario.Name.ToLower() || user.Email.ToLower() == usuario.Email.ToLower());

            if (result != null)
            {
                return "Nome ou Email já Cadastrado";
            }

            try
            {
                _leilaoDbContext.Users.Add(usuario);
                await _leilaoDbContext.SaveChangesAsync();
                return "Created";
            }
            catch
            {
                return "Erro ao tentar fazer a solicitação";
            }
        }

        public async Task<string?> AlterarNameUsuario(int id, string name)
        {
            var result = await _leilaoDbContext.Users.FirstOrDefaultAsync(user => user.Id == id);

            if (result == null)
            {
                return "Não encontrado";
            }

            try
            {
                result.Name = name;
                _leilaoDbContext.Users.Update(result);
                await _leilaoDbContext.SaveChangesAsync();
                return $"{name} - Alterado Com Sucesso";
            }
            catch
            {
                return "Erro ao tentar fazer a solicitação";
            }
        }

        public async Task<string?> AlterarEmailUsuario(int id, string email)
        {
            var result = await _leilaoDbContext.Users.FirstOrDefaultAsync(user => user.Id == id);

            if (result == null)
            {
                return "Não encontrado";
            }

            try
            {
                result.Email = email;
                _leilaoDbContext.Users.Update(result);
                await _leilaoDbContext.SaveChangesAsync();
                return $"{email} - Alterado Com Sucesso";
            }
            catch
            {
                return "Erro ao tentar fazer a solicitação";
            }
        }

        public async Task<string?> AlterarSenhaUsuario(int id, string senha)
        {
            var result = await _leilaoDbContext.Users.FirstOrDefaultAsync(user => user.Id == id);

            if (result == null)
            {
                return "Não encontrado";
            }

            try
            {
                result.Password = senha;
                _leilaoDbContext.Users.Update(result);
                await _leilaoDbContext.SaveChangesAsync();
                return "Senha Alterada Com Sucesso";
            }
            catch
            {
                return "Erro ao tentar fazer a solicitação";
            }
        }

        public async Task<string> DeleteUser(int id)
        {
            var result = await _leilaoDbContext.Users.FirstOrDefaultAsync(user => user.Id == id);

            if (result == null)
            {
                return "Não encontrado";
            }

            try
            {
                _leilaoDbContext.Users.Remove(result);
                await _leilaoDbContext.SaveChangesAsync();
                return "Usuario Excluído Com Sucesso";
            }
            catch
            {
                return "Erro ao tentar fazer a solicitação";
            }
        }
    }
}