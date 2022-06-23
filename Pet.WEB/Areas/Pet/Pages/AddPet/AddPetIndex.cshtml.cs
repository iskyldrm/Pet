using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Pet.BL.Abstract;
using Pet.Entities.Concrete;
using System.ComponentModel.DataAnnotations;

namespace Pet.WEB.Areas.Pet.Pages.AddPet
{
    public class AddPetIndexModel : PageModel
    {
        private readonly SignInManager<User> _signInManager;
        private readonly ILogger<AddPetIndexModel> _logger;
        private readonly IKindManager _kindManager;
        private readonly IGenusManager _genusManager;

        public AddPetIndexModel
            (SignInManager<User> signInManager,
            ILogger<AddPetIndexModel> logger,
            IKindManager kindManager,
            IGenusManager genusManager)
        {
            _signInManager = signInManager;
            _logger = logger;
            _kindManager = kindManager;
            _genusManager = genusManager;
        }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
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

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public class InputModel
        {
            public string LivingName { get; set; }
            public bool LivingGender { get; set; }
            public byte LivingAge { get; set; }
            public int KindId { get; set; }
            public Kind Kind { get; set; }
            public int GenusId { get; set; }
            public Genus Genus { get; set; }
            public List<Image> Images { get; set; }
        }
        public SelectList Kinds { get; set; }
        public SelectList Genuses { get; set; }

        public async Task OnGetAsync(string returnUrl = null)
        {
            Kinds = new SelectList(_kindManager.GetAll(), nameof(Kind.Id), nameof(Kind.KindName));
            Genuses = new SelectList(_genusManager.GetAll(),nameof(Genus.Id),nameof(Genus.GenusName));

        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
