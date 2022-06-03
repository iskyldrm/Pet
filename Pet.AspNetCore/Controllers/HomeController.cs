using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Pet.Entities.Concrete;

namespace Pet.AspNetCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<User> userManager;

        public HomeController(UserManager<User> userManager)
        {
            this.userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }

    }
}
