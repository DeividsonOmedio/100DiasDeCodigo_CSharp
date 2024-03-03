using Domain.Interfaces.ServicesInterfaces;
using Entities.Entities;
using Helpers.Filters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Auction.Api.Controllers
{

    [ServiceFilter(typeof(AuthenticationUserAttributes))]
    public class UsersController(IUsersService usersService) : GenericsController
    {
        private readonly IUsersService _usersService = usersService;

        [ServiceFilter(typeof(AuthenticationAdminAttributes))]
        [HttpGet("GetAllUsers")]
        [ProducesResponseType(typeof(UserModel), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult GetAllUsers()
        {
            var result = _usersService.GetAllUsers();
            if (result == null) return NoContent();
            return Ok(result);
        }

        [HttpGet("GetUserById")]
        public IActionResult GetUserById(int id)
        {
            var result = _usersService.GetUserById(id);
            if (result == null) return NoContent();
            return Ok(result);
        }

        [HttpGet("GetUserByName")]
        public IActionResult GetUserByName(string name)
        {
            var result = _usersService.GetByName(name);
            if (result == null) return Ok("Usuário não encontrado");
            return Ok(result);
        }

        [HttpGet("GetUserByEmail")]
        public IActionResult GetByEmail(string email)
        {
            var result = _usersService.GetByEmail(email);
            if (result == null) return Ok("Usuário não encontrado");
            return Ok(result);
        }

        [HttpPost("CreateUser")]
        public IActionResult CreateUser(UserModel user)
        {
            var result = _usersService.CreateUser(user);
            if (result.ToString() == "Created") return Ok(user);
            return Ok(result);
        }

        [HttpPatch("ChangeNameUser")]
        public IActionResult ChangeNameUser(int id, string name)
        {
            var result = _usersService.ChangeNameUser(id, name);
            return Ok(result);
        }

        [HttpPatch("ChangeEmailUer")]
        public IActionResult ChangeEmailUer(int id, string email)
        {
            var result = _usersService.ChangeEmailUer(id, email);
            return Ok(result);
        }

        [HttpPatch("ChangePasswordUser")]
        public IActionResult ChangePasswordUser(int id, string senha)
        {
            var result = _usersService.ChangePasswordUser(id, senha);
            return Ok(result);
        }

        [HttpDelete("DeleteUser")]
        public IActionResult DeleteUser(int id)
        {
            var result = _usersService.DeleteUser(id);
            return Ok(result);
        }
    }
}
