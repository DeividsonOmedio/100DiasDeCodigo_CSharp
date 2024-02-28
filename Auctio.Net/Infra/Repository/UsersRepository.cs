using Domain.Interfaces.RepositoryInterfaces;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repository
{
    public class UsersRepository : IUsersRepository
    {
        public Task<string?> AlterarEmailUsuario(int id, string email)
        {
            throw new NotImplementedException();
        }

        public Task<string?> AlterarNameUsuario(int id, string name)
        {
            throw new NotImplementedException();
        }

        public Task<string?> AlterarSenhaUsuario(int id, string senha)
        {
            throw new NotImplementedException();
        }

        public Task<string?> CreateUser(UserModel usuario)
        {
            throw new NotImplementedException();
        }

        public Task<string> DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserModel>?> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public Task<UserModel?> GetByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserModel>?> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<UserModel?> GetUserById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
