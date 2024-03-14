using Helpers.Filters;
using Infra.Configurations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Auction.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        private readonly AuctionDbContext _auctionDbContext = new();
        [HttpPost("Auth/{email}/{password}")]
        public ActionResult Auth(string email, string password)
        {
            var result = _auctionDbContext.Users.FirstOrDefault(user => user.Email == email && user.Password == password);
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
