using Domain.Interfaces.RepositoryInterfaces;
using Domain.Interfaces.ServicesInterfaces;
using Entities.Entities;

namespace Domain.Services
{
    public class UsersService : IUsersService
    {
        private readonly IUsersRepository _usersRepository;

        public UsersService(IUsersRepository usersRepository) => _usersRepository = usersRepository;


        public Task<string?> ChangeEmailUer(int id, string email)
        {
            return _usersRepository.ChangeEmailUer(id, email);
        }

        public Task<string?> ChangeNameUser(int id, string name)
        {
            return _usersRepository.ChangeNameUser(id, name);
        }

        public Task<string?> ChangePasswordUser(int id, string password)
        {
            return _usersRepository.ChangePasswordUser(id, password);
        }

        public Task<string?> CreateUser(UserModel user)
        {
            return _usersRepository.CreateUser(user);
        }

        public Task<string> DeleteUser(int id)
        {
            return _usersRepository.DeleteUser(id);
        }

        public Task<List<UserModel>?> GetAllUsers()
        {
            return _usersRepository.GetAllUsers();
        }

        public Task<UserModel?> GetByEmail(string email)
        {
            return _usersRepository.GetByEmail(email);
        }

        public Task<List<UserModel>?> GetByName(string name)
        {
            return _usersRepository.GetByName(name);
        }

        public Task<UserModel?> GetUserById(int id)
        {
            return _usersRepository.GetUserById(id);
        }
    }
}
