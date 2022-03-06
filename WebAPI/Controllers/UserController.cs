using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok();
        }
    }
}
