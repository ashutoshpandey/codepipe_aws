using Microsoft.AspNetCore.Mvc;

namespace CodePipelineApp.Controllers
{
    [ApiController]
    [Route("/home")]
    public class HomeController : ControllerBase
    {
        [HttpGet("status")]
        public IActionResult Status()
        {
            return Ok(new { Status = "Working fine" });
        }
    }
}
