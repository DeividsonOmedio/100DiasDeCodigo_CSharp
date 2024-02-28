using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers.Filters
{
    internal class AuthenticationGenericsAttributes : AuthorizeAttribute, IAuthorizationFilter
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

            }
            catch (Exception ex)
            {
                context.Result = new UnauthorizedObjectResult(ex.Message);
            }
        }

    }
}

