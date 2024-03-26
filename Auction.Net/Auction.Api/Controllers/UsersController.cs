using Domain.Interfaces;
using Domain.Interfaces.ServicesInterfaces;
using Entities.Entities;
using Helpers.Filters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Auction.Api.Controllers
{

    //[ServiceFilter(typeof(AuthenticationAdminAttributes))]
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
        public async Task<ActionResult<UserModel>> GetUserById(int idUser)
        {
            var result = await _usersService.GetUserById(idUser);
            if (result == null) return NoContent();
            return Ok(result);
        }

        [HttpGet("GetUserByName/{nameUser:alpha}")]
        public async Task<ActionResult<UserModel>> GetUserByName(string nameUser)
        {
            var result = await _usersService.GetByName(nameUser);
            if (result == null) return Ok("Usuário não encontrado");
            return Ok(result);
        }

        [HttpGet("GetUserByEmail/{emailUser:alpha}")]
        public async Task<ActionResult<UserModel>> GetByEmail(string emailUser)
        {
            var result = await _usersService.GetByEmail(emailUser);
            if (result == null) return Ok("Usuário não encontrado");
            return Ok(result);
        }

        [HttpPost("CreateUser")]
        public async Task<ActionResult<UserModel>> CreateUser(UserModel user)
        {
            var result = await _usersService.CreateUser(user);
            if (result?.ToString() == "Created") return Ok(user);
            return Ok(result);
        }

        [HttpPatch("ChangeNameUser")]
        public async Task<ActionResult<UserModel>> ChangeNameUser(int id, string name)
        {
            var result = await _usersService.ChangeNameUser(id, name);
            return Ok(result);
        }

        [HttpPatch("ChangeEmailUer/{idUser:int}/{emailUser:alpha}")]
        public async Task<ActionResult<UserModel>> ChangeEmailUer(int idUser, string emailUser)
        {
            var result = await _usersService.ChangeEmailUer(idUser, emailUser);
            return Ok(result);
        }

        [HttpPatch("ChangePasswordUser/{idUser:int}/{passwordUser:alpha}")]
        public async Task<ActionResult<UserModel>> ChangePasswordUser(int idUser, string passwordUser)
        {
            var result = await _usersService.ChangePasswordUser(idUser, passwordUser);
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
