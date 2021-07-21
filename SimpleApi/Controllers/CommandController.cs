using Microsoft.AspNetCore.Mvc;

namespace SimpleApi.Controllers
{
    //api/cm
    [Route("api/cm")]
    [ApiController]
    public class CommandController : ControllerBase
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}