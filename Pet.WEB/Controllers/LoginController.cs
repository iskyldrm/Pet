using Microsoft.AspNetCore.Mvc;
using Pet.WEB.Models;

namespace Pet.WEB.Controllers
{
    public class LoginController : Controller
    {
        

        public LoginController()
        {
            
        }
        [HttpGet]
        public IActionResult Login()
        {
            LoginViewModel loginViewModel = new LoginViewModel();
            return View(loginViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel viewModel)
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
