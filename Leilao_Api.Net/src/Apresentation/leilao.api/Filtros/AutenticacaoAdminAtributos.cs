using leilao.api.Repositorios;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using leilao.api.Interfaces;

namespace leilao.api.Filtros
{
    public class AutenticacaoAdminAtributos : AuthorizeAttribute, IAuthorizationFilter
    {
        private readonly IUsuarioRepositorio _repositorio;
        public AutenticacaoAdminAtributos(IUsuarioRepositorio repositorio) => _repositorio = repositorio;
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
