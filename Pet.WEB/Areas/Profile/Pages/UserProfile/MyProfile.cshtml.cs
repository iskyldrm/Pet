using CloudinaryDotNet;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;
using Pet.BL.Abstract;
using Pet.Entities.Concrete;
using Pet.WEB.Models;
using System.Security.Claims;
using System.Text;

namespace Pet.WEB.Areas.Profile.Pages.UserProfile
{
    public class MyProfileModel : PageModel
    {
        private readonly SignInManager<User> signInManager;
        private readonly UserManager<User> userManager;
        private readonly ILogger<MyProfileModel> logger;
        private readonly IOptions<CloudinarySettings> options;
        private readonly IImageManager �mageManager;
        private readonly ILivingManager livingManager;
        private Cloudinary cloudinary;

        public MyProfileModel(SignInManager<User> signInManager,
            UserManager<User> userManager,
            ILogger<MyProfileModel> logger,
            IOptions<CloudinarySettings> options,
            IImageManager �mageManager,
            ILivingManager livingManager)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
            this.logger = logger;
            this.options = options;
            this.�mageManager = �mageManager;
            this.livingManager = livingManager;
            Account account = new Account(options.Value.CloudName, options.Value.ApiKey, options.Value.ApiSecret);
            cloudinary = new Cloudinary(account);
        }
        public async Task OnGetAsync()
        {
            //Bu koda par�as� kullan�c�n�n �mage bilgisini getirmektedir.
            #region Kullan�c� �mage bilgisi
            var user�nfo = HttpContext.User.Identity.Name;
            if (user�nfo != null)
            {
                var user = userManager.Users.SingleOrDefault(p => p.UserName == user�nfo);
                var �mage = �mageManager.GetAll(p => p.ImageUser == user);
                var url = "";
                if (�mage.Count > 0)
                {
                    url = �mage[0].Url;
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
            #endregion

            //bu kod par�as� kullan�c�n�n canl�s�n�n ismini getirmektedir.
            #region Canl�isimlerinigetirme
            var living�nfo = livingManager.GetAll(p => p.User.UserName == user�nfo);

            StringBuilder names = new StringBuilder();
            for (int i = 0; i < living�nfo.Count; i++)
            {
                names.Append(living�nfo[i].LivingName.ToString());
                if (i > 9)
                    break;
                if (i < living�nfo.Count - 1)
                    names.Append(", ");
            }
            if (living�nfo.Count > 0)
            {


                ViewData["userLivingName"] = names.ToString();


            }
            else
            {
                ViewData["userLivingName"] = "Petiniz yok";
            }  
            #endregion



        }
    }
}
