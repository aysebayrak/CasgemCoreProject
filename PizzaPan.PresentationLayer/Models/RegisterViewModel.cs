using System.ComponentModel.DataAnnotations;

namespace PizzaPan.PresentationLayer.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage ="Ad alanı boş geçirilemez")]
        public string Name { get; set; }
        public string Surname { get; set; }
        [Required(ErrorMessage = "Email alanı boş geçirilemez")]
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        [Compare("Password" , ErrorMessage ="Şifreler Uyuşmuyor")]
        public string ConfirmPassword { get; set; }

   


    }
}
