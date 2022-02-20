using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace File.Controllers
{
    [Route("api/v1/healthCheckController")]
    public class HealthCheckController : ControllerBase
    {
        [HttpGet("testConnection")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public IActionResult TestConnection()
        {
            return Ok();
        }
    }
}
