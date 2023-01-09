using Microsoft.AspNetCore.Mvc;

namespace Web_API_Pattern.Controllers.Config
{
    [Route("/api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class BaseApiController : ControllerBase
    {

    }
}