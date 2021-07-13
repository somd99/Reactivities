using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // placeholder get replaced with controller class name minus the word controller
    public class BaseApiController : ControllerBase
    {
        
    }
}