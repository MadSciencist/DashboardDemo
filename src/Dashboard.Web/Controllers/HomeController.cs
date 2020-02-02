using Microsoft.AspNetCore.Mvc;

namespace Dashboard.Web.Controllers
{
    [Route("/")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Redirect("/swagger");
        }
    }
}