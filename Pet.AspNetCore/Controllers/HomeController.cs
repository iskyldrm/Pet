using Microsoft.AspNetCore.Mvc;

namespace Pet.AspNetCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
