using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Pet.Entities.Concrete;

namespace Pet.AspNetCore.Controllers
{
    public class HomeController : Controller
    {
        

        public HomeController()
        {
            
        }
        public IActionResult Index()
        {
            return View();
        }

    }
}
