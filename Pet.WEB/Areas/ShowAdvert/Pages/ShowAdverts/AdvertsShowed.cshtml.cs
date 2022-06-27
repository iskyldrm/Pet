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
        private readonly IImageManager _ýmageManager;
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
            IImageManager ýmageManager,
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
            _ýmageManager = ýmageManager;
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
            List<AdvertDTO> Advertler = new List<AdvertDTO>();
            AdvertDTO advertDTO = new AdvertDTO();
            var resultAdvert =  _advertManager.GetAll();
            var resultLiving = _livingManager.GetAll(); 

            for (int i = 0; i < resultAdvert.Count; i++)
            {
                var resultImage = _ýmageManager.GetAll(p => p.Advert.Id == resultAdvert[i].Id);

                    advertDTO.AdvertNo = resultAdvert[i].AdvertNo;
                    advertDTO.AdvertType = resultAdvert[i].AdvertType;
                    advertDTO.PetState = resultAdvert[i].PetState;
                    advertDTO.LivingName = resultLiving[i].LivingName;
                    advertDTO.Url = resultImage[0].Url;

                Advertler.Add(advertDTO);
            }

            Adverts = Advertler.ToList();
        }
    }
}
