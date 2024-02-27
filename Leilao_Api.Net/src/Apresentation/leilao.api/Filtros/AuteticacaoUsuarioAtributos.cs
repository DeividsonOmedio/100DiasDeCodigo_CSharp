using leilao.api.CasosDeUso.Usuarios;
using leilao.api.Entities;
using leilao.api.Interfaces;
using leilao.api.Repositorios;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Buffers.Text;
using System.IdentityModel.Tokens.Jwt;

namespace leilao.api.Filtros
{
    public class AuteticacaoUsuarioAtributos : AuthorizeAttribute, IAuthorizationFilter
    {
        FiltrarToken filtrarToken = new();
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            try
            {
                var token = filtrarToken.TokenOnRequest(context.HttpContext);

                if (string.IsNullOrEmpty(token))
                {
                    context.Result = new UnauthorizedObjectResult("Token is missing");
                    return;
                }

                var idUser = filtrarToken.DecodeJwtToken(token);

                var result = filtrarToken.BuscarUser(idUser);

                if (result == null)
                    context.Result = new UnauthorizedObjectResult("not valid");

                if (result?.Tipo == Enums.TipoUsuarioEnum.administrador)
                    context.Result = new UnauthorizedObjectResult("not authorized");
            }
            catch (Exception ex)
            {
                context.Result = new UnauthorizedObjectResult(ex.Message);
            }
        }

    }
}
