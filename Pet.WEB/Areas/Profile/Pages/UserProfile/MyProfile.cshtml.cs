using CloudinaryDotNet;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;
using Pet.BL.Abstract;
using Pet.Entities.Concrete;
using Pet.WEB.Models;
using System.Security.Claims;

namespace Pet.WEB.Areas.Profile.Pages.UserProfile
{
    public class MyProfileModel : PageModel
    {
        private readonly SignInManager<User> signInManager;
        private readonly UserManager<User> userManager;
        private readonly ILogger<MyProfileModel> logger;
        private readonly IOptions<CloudinarySettings> options;
        private readonly IImageManager ýmageManager;
        private Cloudinary cloudinary;

        public MyProfileModel(SignInManager<User> signInManager,
            UserManager<User> userManager,
            ILogger<MyProfileModel> logger,
            IOptions<CloudinarySettings> options,
            IImageManager ýmageManager)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
            this.logger = logger;
            this.options = options;
            this.ýmageManager = ýmageManager;
            Account account = new Account(options.Value.CloudName, options.Value.ApiKey, options.Value.ApiSecret);
            cloudinary = new Cloudinary(account);
        }
        public async Task OnGetAsync()
        {
            var userýnfo = HttpContext.User.Identity.Name;
            if (userýnfo != null)
            {
                var user = userManager.Users.SingleOrDefault(p => p.UserName == userýnfo);
                var ýmage = ýmageManager.GetAll(p => p.ImageUser == user);
                var url = "";
                if (ýmage.Count >0)
                {
                    url = ýmage[0].Url;
                    ViewData["user"] = url;
                }
                else
                {
                    ViewData["user"] = "https://st3.depositphotos.com/1007566/13247/v/600/depositphotos_132471910-stock-illustration-head-human-profile-icon.jpg";
                }
                
            }
            else
            {
                ViewData["User"] = "https://bootdey.com/img/Content/avatar/avatar3.png";
            }
            

            
        }
    }
}
