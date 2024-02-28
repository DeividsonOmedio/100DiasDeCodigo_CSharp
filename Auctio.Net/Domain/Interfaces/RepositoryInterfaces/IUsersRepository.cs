using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.RepositoryInterfaces
{
    public interface IUsersRepository
    {
        Task<List<UserModel>?> GetAllUsers();
        Task<UserModel?> GetUserById(int id);
        Task<List<UserModel>?> GetByName(string name);
        Task<UserModel?> GetByEmail(string email);
        Task<string?> CreateUser(UserModel usuario);
        Task<string?> AlterarNameUsuario(int id, string name);
        Task<string?> AlterarEmailUsuario(int id, string email);
        Task<string?> AlterarSenhaUsuario(int id, string senha);
        Task<string> DeleteUser(int id);
    }
}
