using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Helpers.Filters
{
    public class AuthenticationGenericsAttributes : AuthorizeAttribute, IAuthorizationFilter
    {
        private readonly TokenFilter _tokenFilter = new();

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            try
            {
                var token = TokenFilter.TokenOnRequest(context.HttpContext);
                if (string.IsNullOrEmpty(token))
                {
                    context.Result = new UnauthorizedObjectResult("Token is missing");
                    return;
                }
                var idUser = TokenFilter.DecodeJwtToken(token);
                var result = _tokenFilter.GetUser(idUser);
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

