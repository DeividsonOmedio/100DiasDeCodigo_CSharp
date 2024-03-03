using Domain.Interfaces;
using Domain.Interfaces.ServicesInterfaces;
using Entities.Entities;
using Infra.Configurations;
using Microsoft.AspNetCore.Http;
using System.IdentityModel.Tokens.Jwt;


namespace Helpers.Filters
{
    public class UserLogged(IHttpContextAccessor httpContextAccessor, IUsersService repositorio) : ILoggedUser
    {
        private readonly IHttpContextAccessor _httpContextAccessor = httpContextAccessor;
        private readonly IUsersService _repositorio = repositorio;

        public UserModel User()
        {
            var repository = new AuctionDbContext();
            var token = TokenOnRequest();
            var email = DecodeJwtToken(token);

            return repository.Users.First(user => user.Email.Equals(email));
        }

        private string TokenOnRequest()
        {
            var authentication = _httpContextAccessor.HttpContext!.Request.Headers["Authorization"].ToString();
            return authentication["Bearer ".Length..];
        }

        private string DecodeJwtToken(string token)
        {
            var handler = new JwtSecurityTokenHandler();
            var jsonToken = handler.ReadToken(token) as JwtSecurityToken;

            if (jsonToken == null) throw new ArgumentException("Token inválido");

            var email = jsonToken.Claims.FirstOrDefault(claim => claim.Type == "email")?.Value;

            if (string.IsNullOrEmpty(email)) throw new ArgumentException("Email não encontrado no token");

            return email;
        }
    }
}

