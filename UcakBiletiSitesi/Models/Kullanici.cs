using System.ComponentModel.DataAnnotations;

namespace UcakBiletiSitesi.Models
{
    public class Kullanici
    {
        [Display(Name = "E-posta adresi")]
        [Required]
        [EmailAddress(ErrorMessage = "Lutfen gecerli bir e-mail adresi giriniz")]
        public string Email { get; set; }
        [Display(Name = "Parola")]
        [Required(ErrorMessage = "Lutfen gecerli bir parola giriniz")]
        public string Password { get; set; }
    }
}
