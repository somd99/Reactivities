using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // placeholder get replaced with controller class name minus the word controller
    public class BaseApiController : ControllerBase
    {
        private IMediator _mediator; 

        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices
        .GetService<IMediator>();
    }
}