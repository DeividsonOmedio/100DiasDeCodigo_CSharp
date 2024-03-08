using Bogus;
using Domain.Interfaces.ServicesInterfaces;
using Domain.Services;
using Entities.Entities;
using FluentAssertions;
using Moq;
using Xunit;

namespace Auction.Test
{
    public class UsersServiceTest
    {
        [Fact]
        public async Task ChangeEmailUser_ShouldReturnSuccessMessage()
        {
            // ARRANGE
            var userId = 1;
            var newEmail = "newemail@example.com";
            var successMessage = "Email changed successfully.";
            var mock = new Mock<IUsersService>();
            mock.Setup(i => i.ChangeEmailUer(userId, newEmail)).ReturnsAsync(successMessage);
            var userService = new UsersService(mock.Object);

            // ACTION
            var message = await userService.ChangeEmailUer(userId, newEmail);

            // ASSERT
            message.Should().NotBeNull();
            message.Should().Be(successMessage);
        }

        [Fact]
        public async Task ChangeNameUser_ShouldReturnSuccessMessage()
        {
            // ARRANGE
            var userId = 1;
            var newName = "New Name";
            var successMessage = "Name changed successfully.";
            var mock = new Mock<IUsersService>();
            mock.Setup(i => i.ChangeNameUser(userId, newName)).ReturnsAsync(successMessage);
            var userService = new UsersService(mock.Object);

            // ACTION
            var message = await userService.ChangeNameUser(userId, newName);

            // ASSERT
            message.Should().NotBeNull();
            message.Should().Be(successMessage);
        }

        [Fact]
        public async Task ChangePasswordUser_ShouldReturnSuccessMessage()
        {
            // ARRANGE
            var userId = 1;
            var newPassword = "newpassword123";
            var successMessage = "Password changed successfully.";
            var mock = new Mock<IUsersService>();
            mock.Setup(i => i.ChangePasswordUser(userId, newPassword)).ReturnsAsync(successMessage);
            var userService = new UsersService(mock.Object);

            // ACTION
            var message = await userService.ChangePasswordUser(userId, newPassword);

            // ASSERT
            message.Should().NotBeNull();
            message.Should().Be(successMessage);
        }

        [Fact]
        public async Task CreateUser_ShouldReturnSuccessMessage()
        {
            // ARRANGE
            var newUser = new Faker<UserModel>().Generate();
            var successMessage = "User created successfully.";
            var mock = new Mock<IUsersService>();
            mock.Setup(i => i.CreateUser(newUser)).ReturnsAsync(successMessage);
            var userService = new UsersService(mock.Object);

            // ACTION
            var message = await userService.CreateUser(newUser);

            // ASSERT
            message.Should().NotBeNull();
            message.Should().Be(successMessage);
        }

        [Fact]
        public async Task DeleteUser_ShouldReturnSuccessMessage()
        {
            // ARRANGE
            var userId = 1;
            var successMessage = "User deleted successfully.";
            var mock = new Mock<IUsersService>();
            mock.Setup(i => i.DeleteUser(userId)).ReturnsAsync(successMessage);
            var userService = new UsersService(mock.Object);

            // ACTION
            var message = await userService.DeleteUser(userId);

            // ASSERT
            message.Should().NotBeNull();
            message.Should().Be(successMessage);
        }

        [Fact]
        public async Task GetAllUsers_ShouldReturnListOfUserModels()
        {
            // ARRANGE
            var users = new Faker<UserModel>().Generate(3);
            var mock = new Mock<IUsersService>();
            mock.Setup(i => i.GetAllUsers()).ReturnsAsync(users);
            var userService = new UsersService(mock.Object);

            // ACTION
            var resultUsers = await userService.GetAllUsers();

            // ASSERT
            resultUsers.Should().NotBeNull();
            resultUsers.Should().BeOfType<List<UserModel>>();
            resultUsers.Should().HaveCount(3);  // Certifique-se de ajustar este valor de acordo com o número de elementos gerados
        }

        [Fact]
        public async Task GetByEmail_ShouldReturnUserModel()
        {
            // ARRANGE
            var userEmail = "test@example.com";
            var user = new Faker<UserModel>().Generate();
            var mock = new Mock<IUsersService>();
            mock.Setup(i => i.GetByEmail(userEmail)).ReturnsAsync(user);
            var userService = new UsersService(mock.Object);

            // ACTION
            var resultUser = await userService.GetByEmail(userEmail);

            // ASSERT
            resultUser.Should().NotBeNull();
            resultUser.Should().Be(user);
        }

        [Theory]
        [MemberData(nameof(GetUserTest))]
        public async Task GetByName_ShouldReturnListOfUserModels(string userName)
        {
            // ARRANGE
            var users = new Faker<UserModel>().Generate(3);
            var mock = new Mock<IUsersService>();
            mock.Setup(i => i.GetByName(userName)).ReturnsAsync(users);
            var userService = new UsersService(mock.Object);

            // ACTION
            var resultUsers = await userService.GetByName(userName);

            // ASSERT
            resultUsers.Should().NotBeNull();
            resultUsers.Should().BeOfType<List<UserModel>>();
            resultUsers.Should().HaveCount(3);  // Certifique-se de ajustar este valor de acordo com o número de elementos gerados
        }
        public static IEnumerable<object[]> GetUserTest()
        {
            yield return new object[] { "user1" };
            yield return new object[] { "user5" };
            yield return new object[] { "" };
        }
        [Fact]
        public async Task GetUserById_ShouldReturnUserModel()
        {
            // ARRANGE
            var userId = 1;
            var user = new Faker<UserModel>().Generate();
            var mock = new Mock<IUsersService>();
            mock.Setup(i => i.GetUserById(userId)).ReturnsAsync(user);
            var userService = new UsersService(mock.Object);

            // ACTION
            var resultUser = await userService.GetUserById(userId);

            // ASSERT
            resultUser.Should().NotBeNull();
            resultUser.Should().Be(user);
        }

        // Adicione testes para outros métodos se necessário
    }
}