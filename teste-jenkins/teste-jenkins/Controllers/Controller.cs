using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace teste_jenkins.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult teste()
        {
            return Ok("ola mundo");
        }
    }
}
