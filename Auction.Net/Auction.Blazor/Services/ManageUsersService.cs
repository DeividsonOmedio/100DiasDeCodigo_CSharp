using Auction.Blazor.Services.Interfaces;
using Entities.Entities;

namespace Auction.Blazor.Services
{
    public class ManageUsersService : IManageUsersService
    {
        public Task<string?> ChangeEmailUer(int id, string email)
        {
            throw new NotImplementedException();
        }

        public Task<string?> ChangeNameUser(int id, string name)
        {
            throw new NotImplementedException();
        }

        public Task<string?> ChangePasswordUser(int id, string senha)
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
