using leilao.api.Repositorios;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Buffers.Text;

namespace leilao.api.Filtros
{
    public class AuteticacaoUsuarioAtributos : AuthorizeAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            try
            {
                var repository = new LeilaoDbContext();

                var token = TokenOnRequest(context.HttpContext);

                var email = FromBase64(token);

                var exist = repository.Users.Any(user => user.Email.Equals(email));

                if (exist == false)
                    context.Result = new UnauthorizedObjectResult("E-mail not valid");
            }
            catch (Exception ex)
            {
                context.Result = new UnauthorizedObjectResult(ex.Message);
            }
        }
        private string TokenOnRequest(HttpContext context)
        {
            var authentication = context.Request.Headers.Authorization.ToString();

            if (string.IsNullOrEmpty(authentication))
                throw new Exception("Tokem is missing");

            return authentication["Bearer ".Length..];
        }
        private string FromBase64(string base64)
        {
            var data = Convert.FromBase64String(base64);
            return System.Text.Encoding.UTF8.GetString(data);
        }
    }
}
