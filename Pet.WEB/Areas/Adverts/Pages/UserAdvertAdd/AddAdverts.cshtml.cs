using CloudinaryDotNet;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;
using Pet.WEB.Models;

namespace Pet.WEB.Areas.Adverts.Pages.UserAdvertAdd
{
    public class AddAdvertsModel : PageModel
    {
        private readonly IOptions<CloudinarySettings> options;
        private Cloudinary cloudinary;

        public AddAdvertsModel(IOptions<CloudinarySettings> options)
        {
            this.options = options;
            cloudinary = new Cloudinary(new Account() { ApiKey = options.Value.ApiKey,ApiSecret = options.Value.ApiSecret,Cloud = options.Value.CloudName });
        }
        public void OnGet()
        {
            
        }
    }
}
