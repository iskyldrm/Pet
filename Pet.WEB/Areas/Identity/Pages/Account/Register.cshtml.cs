// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable

using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Options;
using Pet.BL.Abstract;
using Pet.DAL.Abstract;
using Pet.Entities.Concrete;
using Pet.WEB.Models;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Encodings.Web;

namespace Pet.WEB.Areas.Identity.Pages.Account
{
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        private readonly IUserStore<User> _userStore;
        private readonly IUserEmailStore<User> _emailStore;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;
        private readonly IDistrictManager _districtManager;
        private readonly ICityManager _cityManager;
        private readonly IOptions<CloudinarySettings> options;
        private Cloudinary cloudinary;

        public RegisterModel(
            UserManager<User> userManager,
            IUserStore<User> userStore,
            SignInManager<User> signInManager,
            ILogger<RegisterModel> logger,
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
            CloudinaryDotNet.Account account = new CloudinaryDotNet.Account(options.Value.CloudName, options.Value.ApiKey, options.Value.ApiSecret);
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
        public string ReturnUrl { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public class InputModel
        {

            [Required(ErrorMessage = "Kullanıcı adı zorunludur")]
            [Display(Name = "Kullanıcı Adınız")]
            public string UserName { get; set; }


            [Required(ErrorMessage = "Bu kısım zorunludur")]
            [Display(Name = "Adınız")]
            public string Name { get; set; }

            [Required(ErrorMessage = "Bu kısım zorunludur")]
            [Display(Name = "Soyadınız")]
            public string LastName { get; set; }

            [Display(Name = "Cinsiyet")]
            [Required(ErrorMessage = "Bu kısım zorunludur")]
            public bool Gender { get; set; }

            public string ImageId { get; set; } = string.Empty;

            public int CityId { get; set; }
          
            public int DistrictId { get; set; }

            [Display(Name = "Doğum tarihiniz")]
            [Required(ErrorMessage = "Bu kısım zorunludur")]
            public DateTime Age { get; set; }
            public City CityName { get; set; }

            [Required(ErrorMessage = "Bu kısım zorunludur")]
            public bool EmailConfirmed { get; set; } = false;
            public string FullAddress { get; set; }
            public IFormFile formFile { get; set; }

            /// <summary>
            ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
            ///     directly from your code. This API may change or be removed in future releases.
            /// </summary>
            [Required(ErrorMessage = "Bu kısım zorunludur")]
            [EmailAddress]
            [Display(Name = "Email adresinizi giriniz")]
            public string Email { get; set; }

            /// <summary>
            ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
            ///     directly from your code. This API may change or be removed in future releases.
            /// </summary>
            [Required(ErrorMessage = "Bu kısım zorunludur")]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Şifrenizi giriniz")]
            public string Password { get; set; }

            /// <summary>
            ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
            ///     directly from your code. This API may change or be removed in future releases.
            /// </summary>
            [Required(ErrorMessage = "Bu kısım zorunludur")]
            [DataType(DataType.Password)]
            [Display(Name = "Şifrenizi onaylayın")]
            [Compare("Password", ErrorMessage = "Şifreler aynı değil")]
            public string ConfirmPassword { get; set; }


        }
        
        public SelectList Sehirler { get; set; }
      
        public SelectList Ilceler { get; set; }
        public async Task OnGetAsync(string returnUrl = null)
        {
            Sehirler = new SelectList(_cityManager.GetAll(), nameof(City.Id), nameof(City.CityName));
            //Ilceler = new SelectList(_districtManager.GetAll(), nameof(District.Id), nameof(District.DistrictName));
            

            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            var uploadresult = new ImageUploadResult();
            using (var stream = Input.formFile.OpenReadStream())
            {
                var uploadparam = new ImageUploadParams { File = new FileDescription(Input.formFile.Name, stream) };
                uploadresult = cloudinary.Upload(uploadparam);
            }
            var user = CreateUser();
            var ımage = CreateImage();
            ımage.Url = uploadresult.Uri.ToString();
            ımage.ImageUser = user;
            ımage.CreateTime = DateTime.Now;
            ımage.UpdateTime = DateTime.Now;
            ımage.ImageDescription = "Deneme";
            ımage.ImagePath = uploadresult.Uri.ToString();

            List<Image> images = new List<Image>();
            images.Add(ımage);
            
            var address = new Address();
            address.CityId = Input.CityId;
            address.DistrictId = Input.DistrictId;
            address.City = Input.CityName;
            address.UpdateTime = DateTime.Now;
            address.UpdateTime = DateTime.Now;
            address.FullAdsress = Input.FullAddress;
            user.Addresss = address;
            user.LastName = Input.LastName;
            user.Name = Input.Name;
            user.UserName = Input.UserName;
            user.EmailConfirmed = Input.EmailConfirmed;
            //user.EmailConfirmed = false;
            user.Age = DateTime.Now;
            user.Gender = Input.Gender;
            user.Image = images;

            returnUrl ??= Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (ModelState.IsValid)
            {
                

                await _userStore.SetUserNameAsync(user, Input.UserName, CancellationToken.None);
                await _emailStore.SetEmailAsync(user, Input.Email, CancellationToken.None);
                var result = await _userManager.CreateAsync(user, Input.Password);

                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");

                    var userId = await _userManager.GetUserIdAsync(user);
                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { area = "Identity", userId = userId, code = code, returnUrl = returnUrl },
                        protocol: Request.Scheme);

                    await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                        $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                    if (_userManager.Options.SignIn.RequireConfirmedAccount)
                    {
                        return RedirectToPage("RegisterConfirmation", new { email = Input.Email, returnUrl = returnUrl });
                    }
                    else
                    {
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return LocalRedirect(returnUrl);
                    }
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            Sehirler = new SelectList(_cityManager.GetAll(), nameof(City.Id), nameof(City.CityName));
            Ilceler = new SelectList(_districtManager.GetAll(), nameof(District.Id), nameof(District.DistrictName));
            return Page();



            // If we got this far, something failed, redisplay form
        }

        private User CreateUser()
        {
            try
            {
                return Activator.CreateInstance<User>();
            }
            catch
            {
                throw new InvalidOperationException($"Can't create an instance of '{nameof(User)}'. " +
                    $"Ensure that '{nameof(User)}' is not an abstract class and has a parameterless constructor, or alternatively " +
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
