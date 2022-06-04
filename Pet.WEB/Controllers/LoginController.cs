using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Pet.Entities.Concrete;
using Pet.WEB.Models;

namespace Pet.WEB.Controllers
{
    public class LoginController : Controller
    {
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;

        public LoginController(UserManager<User> _userManager, SignInManager<User> _signInManager)
        {
            var validator = _userManager.UserValidators;
            validator.Clear();
            this.userManager = _userManager;
            this.signInManager = _signInManager;
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
          
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }
            else
            {

                var user = await userManager.FindByEmailAsync(viewModel.Email);

                if (user == null)
                {
                    ModelState.AddModelError("", "Mail yada sifre hatalidir.");
                    return View(viewModel);
                }
                if (!await userManager.IsEmailConfirmedAsync(user))
                {
                    ModelState.AddModelError("", "Epostanizi dogrulayin.");
                    return View(viewModel);
                }

                var result = await signInManager.PasswordSignInAsync(user, viewModel.Password, viewModel.RememberMe, true);



                if (result.Succeeded)
                {
                    return RedirectToAction("Login", "Account", new { area = "Admin" });
                }

                ModelState.AddModelError("", "Email Yada sifre Hatalidir.");
                return View(viewModel);
            }
        }
    }
}
