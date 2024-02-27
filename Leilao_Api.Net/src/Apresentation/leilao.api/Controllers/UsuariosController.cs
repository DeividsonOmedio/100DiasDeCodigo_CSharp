using leilao.api.CasosDeUso.Usuarios;
using leilao.api.Entities;
using leilao.api.Filtros;
using leilao.api.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace leilao.api.Controllers
{
    public class UsuariosController : GenericsController
    {
        private readonly IAtualizarUsuariosCasosDeUso _atualizarUsuariosCasosDeUso;

        public UsuariosController(IAtualizarUsuariosCasosDeUso atualizarUsuariosCasosDeUso)
        {
            _atualizarUsuariosCasosDeUso = atualizarUsuariosCasosDeUso;
        }

        [ServiceFilter(typeof(AutenticacaoAdminAtributos))]
        [HttpGet("GetAllUsers")]
        [ProducesResponseType(typeof(UsuarioModel), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult GetAllUsers()
        {
            var result = _atualizarUsuariosCasosDeUso.GetAllUsers();
            if (result == null) return NoContent();
            return Ok(result);
        }

        [HttpGet("GetUserById")]
        public IActionResult GetUserById(int id)
        {
            var result = _atualizarUsuariosCasosDeUso.GetUserById(id);
            if (result == null) return NoContent();
            return Ok(result);
        }

        [HttpGet("GetUserByName")]
        public IActionResult GetUserByName(string name)
        {
            var result = _atualizarUsuariosCasosDeUso.GetByName(name);
            if (result == null) return Ok("Usuário não encontrado");
            return Ok(result);
        }

        [HttpGet("GetUserByEmail")]
        public IActionResult GetByEmail(string email)
        {
            var result = _atualizarUsuariosCasosDeUso.GetByEmail(email);
            if (result == null) return Ok("Usuário não encontrado");
            return Ok(result);
        }

        [HttpPost("CreateUser")]
        public IActionResult CreateUser(UsuarioModel usuario)
        {
            var result = _atualizarUsuariosCasosDeUso.CreateUser(usuario);
            if (result.ToString() == "Created") return Ok(usuario);
            return Ok(result);
        }

        [HttpPatch("AlterarNameUsuario")]
        public IActionResult AlterarNameUsuario(int id, string name)
        {
            var result = _atualizarUsuariosCasosDeUso.AlterarNameUsuario(id, name);
            return Ok(result);
        }

        [HttpPatch("AlterarEmailUsuario")]
        public IActionResult AlterarEmailUsuario(int id, string email)
        {
            var result = _atualizarUsuariosCasosDeUso.AlterarEmailUsuario(id, email);
            return Ok(result);
        }

        [HttpPatch("AlterarSenhaUsuario")]
        public IActionResult AlterarSenhaUsuario(int id, string senha)
        {
            var result = _atualizarUsuariosCasosDeUso.AlterarSenhaUsuario(id, senha);
            return Ok(result);
        }

        [HttpDelete("DeleteUser")]
        public IActionResult DeleteUser(int id)
        {
            var result = _atualizarUsuariosCasosDeUso.DeleteUser(id);
            return Ok(result);
        }
    }
}
