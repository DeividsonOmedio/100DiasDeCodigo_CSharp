using leilao.api.Entities;
using leilao.api.Repositorios;

namespace leilao.api.Services
{
    public class UsuarioLogado
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UsuarioLogado(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public UsuarioModel Usuer()
        {
            var repository = new LeilaoDbContext();
            var token = TokenOnRequest();
            var email = FromBase64(token);

            return repository.Users.First(user => user.Email.Equals(email));
        }
        private string TokenOnRequest()
        {
            var authentication = _httpContextAccessor.HttpContext!.Request.Headers.Authorization.ToString();

           

            return authentication["Bearer ".Length..];
        }
        private string FromBase64(string base64)
        {
            var data = Convert.FromBase64String(base64);
            return System.Text.Encoding.UTF8.GetString(data);
        }
    }
}
