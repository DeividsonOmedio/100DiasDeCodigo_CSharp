using Domain.Interfaces.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers.Filters
{
    public class AuthenticationAdminAttributes : AuthorizeAttribute, IAuthorizationFilter
    {
        private readonly IUsersRepository _repositorio;
        public AutenticacaoAdminAtributos(IUsersRepository repositorio) => _repositorio = repositorio;
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            try
            {
                var token = _repositorio.TokenOnRequest(context.HttpContext);

                if (string.IsNullOrEmpty(token))
                {
                    context.Result = new UnauthorizedObjectResult("Token is missing");
                    return;
                }

                var idUser = _repositorio.DecodeJwtToken(token);

                var result = _repositorio.BuscarUser(idUser);

                if (result == null)
                    context.Result = new UnauthorizedObjectResult("not valid");
                if (result?.Tipo != Enums.TipoUsuarioEnum.administrador)
                    context.Result = new UnauthorizedObjectResult("not authorized");
            }
            catch (Exception ex)
            {
                context.Result = new UnauthorizedObjectResult(ex.Message);
            }
        }

    }
}
