using Domain.Interfaces;
using Domain.Interfaces.ServicesInterfaces;
using Entities.Entities;
using Helpers.Filters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Auction.Api.Controllers
{

    [ServiceFilter(typeof(AuthenticationAdminAttributes))]
    public class UsersController(IUsersService usersService, ILoggedUser loggedUser) : GenericsController
    {
        private readonly IUsersService _usersService = usersService;
        private readonly ILoggedUser _loggedUser = loggedUser;

        [ServiceFilter(typeof(AuthenticationAdminAttributes))]
        [HttpGet("GetAllUsers")]
        [ProducesResponseType(typeof(UserModel), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<ActionResult<List<UserModel>>> GetAllUsers()
        {
            var result = await _usersService.GetAllUsers();
            if (result == null) return NoContent();
            return Ok(result);
        }

        [HttpGet("GetUserById/{idUser:int}")]
        public IActionResult GetUserById(int idUser)
        {
            var result = _usersService.GetUserById(idUser);
            if (result == null) return NoContent();
            return Ok(result);
        }

        [HttpGet("GetUserByName/{nameUser:alpha}")]
        public IActionResult GetUserByName(string nameUser)
        {
            var result = _usersService.GetByName(nameUser);
            if (result == null) return Ok("Usuário não encontrado");
            return Ok(result);
        }

        [HttpGet("GetUserByEmail/{emailUser:alpha}")]
        public IActionResult GetByEmail(string emailUser)
        {
            var result = _usersService.GetByEmail(emailUser);
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

        [HttpPatch("ChangeEmailUer/{idUser:int}/{emailUser:alpha}")]
        public IActionResult ChangeEmailUer(int idUser, string emailUser)
        {
            var result = _usersService.ChangeEmailUer(idUser, emailUser);
            return Ok(result);
        }

        [HttpPatch("ChangePasswordUser/{idUser:int}/{passwordUser:alpha}")]
        public IActionResult ChangePasswordUser(int idUser, string passwordUser)
        {
            var result = _usersService.ChangePasswordUser(idUser, passwordUser);
            return Ok(result);
        }

        [HttpDelete("DeleteUser/{idUser:int}")]
        public IActionResult DeleteUser(int idUser)
        {
            var result = _usersService.DeleteUser(idUser);
            return Ok(result);
        }
    }
}
