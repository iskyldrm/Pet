using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pet.BL.Abstract;
using Pet.Entities.Concrete;
using Pet.WEB.DTO;

namespace Pet.WEB.Areas.ShowAdvert.Pages.ShowAdverts
{
    public class AdvertsShowedModel : PageModel
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        private readonly IUserStore<User> _userStore;
        private readonly ILogger<AdvertsShowedModel> _logger;
        private readonly IGenusManager _menuManager;
        private readonly IKindManager _kindManager;
        private readonly IDistrictManager _districtManager;
        private readonly ICityManager _cityManager;
        private readonly IImageManager _�mageManager;
        private readonly ILivingManager _livingManager;
        private IAdvertManager _advertManager;
        public AdvertsShowedModel(UserManager<User> userManager,
            IUserStore<User> userStore,
            SignInManager<User> signInManager,
            ILogger<AdvertsShowedModel> logger,
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
        }
        public List<AdvertDTO> Adverts { get; set; }

        public async Task OnGetAsync()
        {
            Adverts = new List<AdvertDTO>();
            AdvertDTO advertDTO = new AdvertDTO();
            var resultAdvert =  _advertManager.GetAll();

            foreach (var item in resultAdvert)
            {
                advertDTO.AdvertNo = item.AdvertNo;
                advertDTO.AdvertType = item.AdvertType;
                advertDTO.PetState = item.PetState;
                advertDTO.Url = item.Image[0].Url;
                Adverts.Add(advertDTO);
            }
            
            

        }
    }
}
