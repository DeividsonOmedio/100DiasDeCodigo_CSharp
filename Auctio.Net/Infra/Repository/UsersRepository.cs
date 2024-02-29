using Domain.Interfaces.RepositoryInterfaces;
using Entities.Entities;
using Infra.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repository
{
    public class UsersRepository : IUsersRepository
    {
        private readonly AuctionDbContext _auctionDbContext;

        public UsersRepository(AuctionDbContext auctionDbContext) => _auctionDbContext = auctionDbContext;

        public async Task<List<UserModel>?> GetAllUsers()
        {
            try
            {
                return await _auctionDbContext.Users.ToListAsync();
            }
            catch
            {
                return null;
            }
        }

        public async Task<UserModel?> GetByEmail(string email)
        {
            try
            {
                return await _auctionDbContext.Users
                    .FirstOrDefaultAsync(user => user.Email.ToLower() == (email.ToLower()));
            }
            catch
            {
                return null;
            }
        }

        public async Task<List<UserModel>?> GetByName(string name)
        {
            try
            {
                return await _auctionDbContext.Users
                    .Where(user => user.Name.ToLower().Contains(name.ToLower()))
                    .ToListAsync();
            }
            catch
            {
                return null;
            }
        }

        public async Task<UserModel?> GetUserById(int id)
        {
            try
            {
                return await _auctionDbContext.Users.FirstOrDefaultAsync(user => user.Id == id);
            }
            catch
            {
                return null;
            }
        }

        public async Task<string?> ChangeEmailUer(int id, string email)
        {
            var result = await _auctionDbContext.Users.FirstOrDefaultAsync(user => user.Id == id);

            if (result == null)
            {
                return "Não encontrado";
            }

            try
            {
                result.Email = email;
                _auctionDbContext.Users.Update(result);
                await _auctionDbContext.SaveChangesAsync();
                return $"{email} - Alterado Com Sucesso";
            }
            catch
            {
                return "Erro ao tentar fazer a solicitação";
            }
        }

        public async Task<string?> ChangeNameUser(int id, string name)
        {
            var result = await _auctionDbContext.Users.FirstOrDefaultAsync(user => user.Id == id);

            if (result == null)
            {
                return "Não encontrado";
            }

            try
            {
                result.Name = name;
                _auctionDbContext.Users.Update(result);
                await _auctionDbContext.SaveChangesAsync();
                return $"{name} - Alterado Com Sucesso";
            }
            catch
            {
                return "Erro ao tentar fazer a solicitação";
            }
        }

        public async Task<string?> ChangePasswordUser(int id, string senha)
        {
            var result = await _auctionDbContext.Users.FirstOrDefaultAsync(user => user.Id == id);

            if (result == null)
            {
                return "Não encontrado";
            }

            try
            {
                result.Password = senha;
                _auctionDbContext.Users.Update(result);
                await _auctionDbContext.SaveChangesAsync();
                return "Senha Alterada Com Sucesso";
            }
            catch
            {
                return "Erro ao tentar fazer a solicitação";
            }
        }

        public async Task<string?> CreateUser(UserModel usuario)
        {
            var result = await _auctionDbContext.Users.FirstOrDefaultAsync(user =>
                          user.Name.ToLower() == usuario.Name.ToLower() || user.Email.ToLower() == usuario.Email.ToLower());

            if (result != null)
            {
                return "Nome ou Email já Cadastrado";
            }

            try
            {
                _auctionDbContext.Users.Add(usuario);
                await _auctionDbContext.SaveChangesAsync();
                return "Created";
            }
            catch
            {
                return "Erro ao tentar fazer a solicitação";
            }
        }

        public async Task<string> DeleteUser(int id)
        {
            var result = await _auctionDbContext.Users.FirstOrDefaultAsync(user => user.Id == id);

            if (result == null)
            {
                return "Não encontrado";
            }

            try
            {
                _auctionDbContext.Users.Remove(result);
                await _auctionDbContext.SaveChangesAsync();
                return "Usuario Excluído Com Sucesso";
            }
            catch
            {
                return "Erro ao tentar fazer a solicitação";
            }
        }
    }
}
