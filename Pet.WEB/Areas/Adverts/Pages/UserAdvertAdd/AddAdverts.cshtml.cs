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
        private readonly IImageManager _ýmageManager;
        private readonly ILivingManager _livingManager;

        public AddAdvertsModel(
            UserManager<User> userManager,
            IUserStore<User> userStore,
            SignInManager<User> signInManager,
            ILogger<AddAdvertsModel> logger,
            IGenusManager menuManager,
            IKindManager kindManager,
            IDistrictManager districtManager,
            ICityManager cityDAL,
            IImageManager ýmageManager,
            ILivingManager livingManager)

        {
            _userManager = userManager;
            _userStore = userStore;
            _signInManager = signInManager;
            _logger = logger;
            _menuManager = menuManager;
            _kindManager = kindManager;
            _districtManager = districtManager;
            _cityManager = cityDAL;
            _ýmageManager = ýmageManager;
            _livingManager = livingManager;
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
            [Display(Name = "Ýlan no")]
            public string? AdvertNo { get; set; }
            public AdvertType AdvertType { get; set; }
            public string? PetState { get; set; }
            [Required]
            public string LivinId { get; set; }
            public Living Living { get; set; }
            public string ImageId { get; set; }
            public virtual List<Image>? Image { get; set; }
            public int? FavoriteId { get; set; }
            public virtual List<Favorite>? Favorites { get; set; }
            public string UserId { get; set; }
            public virtual User? User { get; set; }
            public int CityId { get; set; }
            public int DistrictId { get; set; }
            public City? CityName { get; set; }
        }
        public SelectList Sehirler { get; set; }
        public SelectList Ilceler { get; set; }
        public SelectList Kinds { get; set; }
        public SelectList Livings { get; set; }
        public async Task OnGetAsync(string returnUrl = null)
        {
            #region KullanýcýImagebilgisigetirme
            var userýnfo = HttpContext.User.Identity.Name;
            if (userýnfo != null)
            {
                var user = _userManager.Users.SingleOrDefault(p => p.UserName == userýnfo);
                var ýmage = _ýmageManager.GetAll(p => p.ImageUser == user);
                var url = "";
                if (ýmage.Count > 0)
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
            #endregion

            #region Canlýisimlerinigetirme
            var livingýnfo = _livingManager.GetAll(p => p.User.UserName == userýnfo);

            StringBuilder names = new StringBuilder();
            for (int i = 0; i < livingýnfo.Count; i++)
            {
                names.Append(livingýnfo[i].LivingName.ToString());
                if (i > 9)
                    break;
                if (i < livingýnfo.Count - 1)
                    names.Append(", ");
            }
            if (livingýnfo.Count > 0)
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
            Livings = new SelectList(_livingManager.GetAll(), nameof(Living.Id), nameof(Living.LivingName));


            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }
        public async Task<IActionResult> OnPostAsync()
        {

            Sehirler = new SelectList(_cityManager.GetAll(), nameof(City.Id), nameof(City.CityName));
            Kinds = new SelectList(_kindManager.GetAll(), nameof(Kind.Id), nameof(Kind.KindName));
            Livings = new SelectList(_livingManager.GetAll(), nameof(Living.Id), nameof(Living.LivingName));
            return RedirectToPage("/UserProfile/MyProfile", new { area = "Profile" });

        }



    }
}
