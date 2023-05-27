using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PortalController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult> GetEServices()
        {
            
            return Ok();
        }
    }
}
