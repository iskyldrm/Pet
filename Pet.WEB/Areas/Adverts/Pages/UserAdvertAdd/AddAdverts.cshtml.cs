using CloudinaryDotNet;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;
using Pet.BL.Abstract;
using Pet.Entities.Concrete;
using Pet.WEB.Models;
using System.ComponentModel.DataAnnotations;

namespace Pet.WEB.Areas.Adverts.Pages.UserAdvertAdd
{
    public class AddAdvertsModel : PageModel
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        private readonly IUserStore<User> _userStore;
        private readonly IUserEmailStore<User> _emailStore;
        private readonly ILogger<AddAdvertsModel> _logger;
        private readonly IEmailSender _emailSender;
        private readonly IDistrictManager _districtManager;
        private readonly ICityManager _cityManager;
        private readonly IOptions<CloudinarySettings> options;
        private Cloudinary cloudinary;

        public AddAdvertsModel(
            UserManager<User> userManager,
            IUserStore<User> userStore,
            SignInManager<User> signInManager,
            ILogger<AddAdvertsModel> logger,
            IEmailSender emailSender,
            IDistrictManager districtManager,
            ICityManager cityDAL,
            IOptions<CloudinarySettings> options)

        {
            _userManager = userManager;
            _userStore = userStore;
            _emailStore = GetEmailStore();
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            _districtManager = districtManager;
            this._cityManager = cityDAL;
            this.options = options;
            cloudinary = new Cloudinary(new Account() { ApiKey = options.Value.ApiKey,ApiSecret = options.Value.ApiSecret,Cloud = options.Value.CloudName });
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
        //public string AdvertNo { get; set; } // ilan no
        //public AdvertType AdvertType { get; set; }
        //public string PetState { get; set; }
        //public virtual List<Image>? Image { get; set; }
        //public virtual List<Favorite> Favorites { get; set; }
        //public string UserId { get; set; }
        //public virtual User? User { get; set; }
        //public int AddressId { get; set; }
        //public virtual Address? Address { get; set; }
        //public DateTime CreateTime { get; set; }
        //public DateTime UpdateTime { get; set; }
        public class InputModel
        {
            [Display(Name = "Ýlan no")]
            public string? AdvertNo { get; set; }
            public AdvertType AdvertType { get; set; }
            public string? PetState { get; set; }
            [Required]
            public Living Living { get; set; }
            public virtual List<Image>? Image { get; set; }
            public virtual List<Favorite>? Favorites { get; set; }
            public string UserId { get; set; }
            public virtual User? User { get; set; }
            public int CityId { get; set; }

            public int DistrictId { get; set; }
            public City? CityName { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {

            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }


        private IUserEmailStore<User> GetEmailStore()
        {
            if (!_userManager.SupportsUserEmail)
            {
                throw new NotSupportedException("The default UI requires a user store with email support.");
            }
            return (IUserEmailStore<User>)_userStore;
        }
    }
}
