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
        private readonly TokenFilter _tokenFilter = new();
        public async void OnAuthorization(AuthorizationFilterContext context)
        {
            try
            {
                var token = _tokenFilter.TokenOnRequest(context.HttpContext);

                if (string.IsNullOrEmpty(token))
                {
                    context.Result = new UnauthorizedObjectResult("Token is missing");
                    return;
                }

                var idUser = _tokenFilter.DecodeJwtToken(token);

                var result = await _tokenFilter.GetUser(idUser);

                if (result == null)
                    context.Result = new UnauthorizedObjectResult("not valid");

                if (result?.Type == Entities.Enums.TypeUserEnum.administrator)
                    context.Result = new UnauthorizedObjectResult("not authorized");
            }
            catch (Exception ex)
            {
                context.Result = new UnauthorizedObjectResult(ex.Message);
            }
        }

    }
}