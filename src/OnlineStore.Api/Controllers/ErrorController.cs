using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace OnlineStore.Api.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    [ApiController]
    public class ErrorController : Controller
    {
        [Route("/error")]
        public IActionResult HandleError()
        {
            var error = HttpContext.Features.Get<IExceptionHandlerFeature>()!.Error;
            return Problem(title: error.ToString());
        }
    }
}
