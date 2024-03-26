using Helpers.Filters;
using Microsoft.AspNetCore.Mvc;

namespace Auction.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    //[ServiceFilter(typeof(AuthenticationGenericsAttributes))]
    public class GenericsController : ControllerBase
    {
    }
}