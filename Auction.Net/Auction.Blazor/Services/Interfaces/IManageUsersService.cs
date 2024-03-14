using Entities.Entities;

namespace Auction.Blazor.Services.Interfaces
{
    public interface IManageUsersService
    {
        Task<IEnumerable<UserModel>?> GetAllUsers();
        Task<UserModel?> GetUserById(int id);
        Task<IEnumerable<UserModel>?> GetByName(string name);
        Task<UserModel?> GetByEmail(string email);
        Task<string?> CreateUser(UserModel usuario);
        Task<string?> ChangeNameUser(int id, string name);
        Task<string?> ChangeEmailUer(int id, string email);
        Task<string?> ChangePasswordUser(int id, string senha);
        Task<string?> DeleteUser(int id);
    }
}
