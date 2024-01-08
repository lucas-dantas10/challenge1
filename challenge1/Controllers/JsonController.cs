using Microsoft.AspNetCore.Mvc;

namespace challenge1.Controllers
{
    [ApiController]
    [Route("/")]
    [Produces("application/json")]
    public class JsonController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            Dictionary<string, string> response = new Dictionary<string, string>
            {
                {"message", "Olá, Mundo!" }
            };

            return Json(response);
        }
    }
}
