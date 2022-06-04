using System.ComponentModel.DataAnnotations;

namespace Pet.WEB.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "e-posta adresinizi giriniz")]
        [EmailAddress]
        public string Email { get; set; }


        [Required(ErrorMessage ="Şifrenizi giriniz")]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        public bool RememberMe { get; set; }=false;

      //public string? Token { get; set; }
    }
}
