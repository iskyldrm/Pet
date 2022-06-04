using System.ComponentModel.DataAnnotations;

namespace Pet.WEB.Models
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }


        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        public bool RememberMe { get; set; } = true;

        public string? Token { get; set; }
    }
}
