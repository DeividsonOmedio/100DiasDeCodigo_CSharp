using leilao.api.Entities;
using leilao.api.Interfaces;
using leilao.api.Repositorios;
using System.IdentityModel.Tokens.Jwt;

namespace leilao.api.Services
{
    public class UsuarioLogado
    {
       
            private readonly IHttpContextAccessor _httpContextAccessor;
            private readonly IUsuarioRepositorio _repositorio;

            public UsuarioLogado(IHttpContextAccessor httpContextAccessor, IUsuarioRepositorio repositorio)
            {
                _httpContextAccessor = httpContextAccessor;
                _repositorio = repositorio;
            }   

            public UsuarioModel ObterUsuario()
            {
                var repository = new LeilaoDbContext();
                var token = TokenOnRequest();
                var email = DecodeJwtToken(token);

                return repository.Users.First(user => user.Email.Equals(email));
            }

            private string TokenOnRequest()
            {
                var authentication = _httpContextAccessor.HttpContext!.Request.Headers.Authorization.ToString();
                return authentication["Bearer ".Length..];
            }

            private string DecodeJwtToken(string token)
            {
                var handler = new JwtSecurityTokenHandler();
                var jsonToken = handler.ReadToken(token) as JwtSecurityToken;

                if (jsonToken == null)
                {
                    // Tratar erro de token inválido, se necessário.
                    throw new ArgumentException("Token inválido");
                }

                // Obter o email do token
                var email = jsonToken.Claims.FirstOrDefault(claim => claim.Type == "email")?.Value;

                if (string.IsNullOrEmpty(email))
                {
                    // Tratar erro se o email não estiver presente no token.
                    throw new ArgumentException("Email não encontrado no token");
                }

                return email;
            }
        }
    }

