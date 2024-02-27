using leilao.api.Repositorios;
using leilao.api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace leilao.api.Controllers
{
   
    public class TokenController : GenericsController
    {
        private readonly LeilaoDbContext _leilaoDbContext = new();
        [HttpPost]
        public IActionResult Auth(string email, string password)
        {
            var result = _leilaoDbContext.Users.FirstOrDefault(user => user.Email == email && user.Password == password);
            if (result == null) return NotFound("Email ou senha incorretos");
            try
            {
            var token = TokenServices.GenerateToken(result);
            return Ok(token);
            }
            catch
            {
                return null;
            }
        }
    }
}
