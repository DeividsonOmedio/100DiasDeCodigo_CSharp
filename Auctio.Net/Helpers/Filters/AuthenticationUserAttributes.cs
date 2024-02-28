using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers.Filters
{
    public class AuthenticationUserAttributes : AuthorizeAttribute, IAuthorizationFilter
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