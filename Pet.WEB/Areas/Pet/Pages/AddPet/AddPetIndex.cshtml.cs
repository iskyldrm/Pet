using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Options;
using Pet.BL.Abstract;
using Pet.Entities.Concrete;
using Pet.WEB.Models;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Pet.WEB.Areas.Pet.Pages.AddPet
{
    public class AddPetIndexModel : PageModel
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> userManager;
        private readonly ILogger<AddPetIndexModel> _logger;
        private readonly IKindManager _kindManager;
        private readonly IGenusManager _genusManager;
        private readonly ILivingManager livingManager;
        private Cloudinary cloudinary;
        private IOptions<CloudinarySettings> options;
        private readonly IImageManager ýmageManager;

        public AddPetIndexModel
            (SignInManager<User> signInManager,
            UserManager<User> userManager,
            ILogger<AddPetIndexModel> logger,
            IKindManager kindManager,
            IGenusManager genusManager,
            ILivingManager livingManager,
            IOptions<CloudinarySettings> options, 
            IImageManager ýmageManager)
        {
            _signInManager = signInManager;
            this.userManager = userManager;
            _logger = logger;
            _kindManager = kindManager;
            _genusManager = genusManager;
            this.livingManager = livingManager;
            this.options = options;
            this.ýmageManager = ýmageManager;
            Account account = new Account(options.Value.CloudName,options.Value.ApiKey,options.Value.ApiSecret);
            cloudinary = new Cloudinary(account);
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
            public int GenusId { get; set; }
            [Required(ErrorMessage ="Resim eklemeden olmaz")]
            public IFormFile formFile { get; set; }
            public string Description { get; set; }
        }
        public SelectList Kinds { get; set; }
        public SelectList Genuses { get; set; }

        public async Task OnGetAsync()
        {
            #region Kulanýcý ýmage bilgisi
            var userýnfo = HttpContext.User.Identity.Name;
            if (userýnfo != null)
            {
                var user = userManager.Users.SingleOrDefault(p => p.UserName == userýnfo);
                var ýmage = ýmageManager.GetAll(p => p.ImageUser == user);
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
            #endregion //Kullanýcnýn isminden image bilgisi geitirliyor

            #region Canlýisimlerinigetirme
            var livingýnfo = livingManager.GetAll(p => p.User.UserName == userýnfo);

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

            Kinds = new SelectList(_kindManager.GetAll(), nameof(Kind.Id), nameof(Kind.KindName));
            //Genuses = new SelectList(_genusManager.GetAll(),nameof(Genus.Id),nameof(Genus.GenusName));
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var uploadresult = new ImageUploadResult();
            using (var stream = Input.formFile.OpenReadStream())
            {
                var uploadparam = new ImageUploadParams { File = new FileDescription(Input.formFile.Name , stream) };
                uploadresult = cloudinary.Upload(uploadparam);  
            }
            
            var living = CreateLiving();
            var user = userManager.GetUserId(HttpContext.User);
            List<Image> images = new List<Image>();

            var ýmage = CreateImage();

            ýmage.Living = living;
            ýmage.Url = uploadresult.Uri.ToString();
            ýmage.CreateTime = DateTime.Now;
            ýmage.UpdateTime = DateTime.Now;
            ýmage.ImageDescription = Input.Description;
            ýmage.ImagePath = uploadresult.Uri.ToString();
            images.Add(ýmage);

            living.LivingName = Input.LivingName;
            living.LivingGender = Input.LivingGender;
            living.LivingAge = Input.LivingAge;
            living.KindId = Input.KindId;
            living.GenusId = Input.GenusId;
            living.CreateTime = DateTime.Now;
            living.UpdateTime = DateTime.Now;
            living.UserId = user;
            living.Images = images;

            if (ModelState.IsValid)
            {
                    var result = livingManager.Add(living);
                ViewData["result"] = result;

            }
            Kinds = new SelectList(_kindManager.GetAll(), nameof(Kind.Id), nameof(Kind.KindName));
            //Genuses = new SelectList(_genusManager.GetAll(), nameof(Genus.Id), nameof(Genus.GenusName));

            return RedirectToPage("/UserProfile/MyProfile", new { area = "Profile" });
        }
        private Living CreateLiving()
        {
            try
            {
                return Activator.CreateInstance<Living>();
            }
            catch
            {
                throw new InvalidOperationException($"Can't create an instance of '{nameof(Living.LivingName)}'. " +
                    $"Ensure that '{nameof(Living.LivingName)}' is not an abstract class and has a parameterless constructor, or alternatively " +
                    $"override the register page in /Areas/Identity/Pages/Account/Register.cshtml");
            }
        }
        private Image CreateImage()
        {
            try
            {
                return Activator.CreateInstance<Image>();
            }
            catch
            {
                throw new InvalidOperationException($"Can't create an instance of '{nameof(Image.Id)}'. " +
                    $"Ensure that '{nameof(Image.Living)}' is not an abstract class and has a parameterless constructor, or alternatively ");
            }
        }


    }

}
