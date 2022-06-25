using CloudinaryDotNet;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Options;
using Pet.BL.Abstract;
using Pet.Entities.Concrete;
using Pet.WEB.Models;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Pet.WEB.Areas.Adverts.Pages.UserAdvertAdd
{
    public class AddAdvertsModel : PageModel
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        private readonly IUserStore<User> _userStore;
        private readonly ILogger<AddAdvertsModel> _logger;
        private readonly IGenusManager _menuManager;
        private readonly IKindManager _kindManager;
        private readonly IDistrictManager _districtManager;
        private readonly ICityManager _cityManager;
        private readonly IImageManager _�mageManager;
        private readonly ILivingManager _livingManager;
        private readonly IAdvertManager _advertManager;

        public AddAdvertsModel(
            UserManager<User> userManager,
            IUserStore<User> userStore,
            SignInManager<User> signInManager,
            ILogger<AddAdvertsModel> logger,
            IGenusManager menuManager,
            IKindManager kindManager,
            IDistrictManager districtManager,
            ICityManager cityDAL,
            IImageManager �mageManager,
            ILivingManager livingManager,
            IAdvertManager advertManager)

        {
            _userManager = userManager;
            _userStore = userStore;
            _signInManager = signInManager;
            _logger = logger;
            _menuManager = menuManager;
            _kindManager = kindManager;
            _districtManager = districtManager;
            _cityManager = cityDAL;
            _�mageManager = �mageManager;
            _livingManager = livingManager;
            _advertManager = advertManager;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public string ReturnUrl { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        [TempData]
        public string ErrorMessage { get; set; }

        public class InputModel
        {
            
            public string AdvertNo { get; set; }
            public AdvertType AdvertType { get; set; }
            public string PetState { get; set; }
            public string LivingId { get; set; }
            //public Living? Living { get; set; }
            public int CityId { get; set; }
            public int DistrictId { get; set; }
            public City? CityName { get; set; }
        }
        public SelectList Sehirler { get; set; }
        public SelectList Ilceler { get; set; }
        public SelectList Kinds { get; set; }
        public SelectList Livings { get; set; }
        public async Task OnGetAsync()
        {
            #region Kullan�c�Imagebilgisigetirme
            var user�nfo = HttpContext.User.Identity.Name;
            if (user�nfo != null)
            {
                var user = _userManager.Users.SingleOrDefault(p => p.UserName == user�nfo);
                var �mage = _�mageManager.GetAll(p => p.ImageUser == user);
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

            #region Canl�isimlerinigetirme
            var living�nfo = _livingManager.GetAll(p => p.User.UserName == user�nfo);

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
            Sehirler = new SelectList(_cityManager.GetAll(), nameof(City.Id), nameof(City.CityName));
            Kinds = new SelectList(_kindManager.GetAll(), nameof(Kind.Id), nameof(Kind.KindName));
            Livings = new SelectList(_livingManager.GetAll(p=>p.User.UserName== HttpContext.User.Identity.Name), nameof(Living.Id), nameof(Living.LivingName));


            
        }
        public async Task<IActionResult> OnPostAsync()
        {
            //Input.UserId = _userManager.GetUserId(HttpContext.User).ToString();
            
            var advert = CreateAdvert();
            var living = _livingManager.GetAll(p=>p.Id.ToString() == Input.LivingId);
            
            var adress = CreateAddress();
            
            adress.CityId = Input.CityId;
            adress.DistrictId = Input.DistrictId;
            adress.City = Input.CityName;
            adress.UpdateTime = DateTime.Now;
            adress.UpdateTime = DateTime.Now;
            adress.FullAdsress = " ";


            advert.AdvertNo = Input.AdvertNo;//A��klma giri�idir
            advert.AdvertType = Input.AdvertType;
            advert.CreateTime = DateTime.Now;
            advert.UpdateTime = DateTime.Now;
            advert.PetState = Input.PetState;
            advert.UserId = _userManager.GetUserId(HttpContext.User).ToString();
            advert.Address = adress;
            

            if (ModelState.IsValid)
            {
                var result = _advertManager.Add(advert);
            }






            
            return RedirectToPage("/UserProfile/MyProfile", new { area = "Profile" });

        }

        private Advert CreateAdvert()
        {
            try
            {
                return Activator.CreateInstance<Advert>();
            }
            catch
            {
                throw new InvalidOperationException($"Can't create an instance of '{nameof(Advert.Id)}'. " +
                    $"Ensure that '{nameof(Advert.Living.LivingName)}' is not an abstract class and has a parameterless constructor, or alternatively " +
                    $"override the register page in /Areas/Identity/Pages/Account/Register.cshtml");
            }
        }

        private Address CreateAddress()
        {
            try
            {
                return Activator.CreateInstance<Address>();
            }
            catch
            {
                throw new InvalidOperationException($"Can't create an instance of '{nameof(Address.Id)}'. " +
                    $"Ensure that '{nameof(Address.FullAdsress)}' is not an abstract class and has a parameterless constructor, or alternatively " +
                    $"override the register page in /Areas/Identity/Pages/Account/Register.cshtml");
            }
        }
        private Living CreateLiving()
        {
            try
            {
                return Activator.CreateInstance<Living>();
            }
            catch
            {
                throw new InvalidOperationException($"Can't create an instance of '{nameof(Address.Id)}'. " +
                    $"Ensure that '{nameof(Address.FullAdsress)}' is not an abstract class and has a parameterless constructor, or alternatively " +
                    $"override the register page in /Areas/Identity/Pages/Account/Register.cshtml");
            }
        }


    }
}
