using leilao.api.Filtros;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace leilao.api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [ServiceFilter(typeof(AutenticacaoGenericAtributos))]
    public class GenericsController : ControllerBase
    {
    }
}
