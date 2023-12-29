using System.ComponentModel.DataAnnotations;

namespace UcakBiletiSitesi.Models
{
    public class Havaalani
    {
        [Key] public int HavaalaniId { get; set; }
        [Required] public string SehirAd { get; set; }
        [Required] public string HavaalaniAd { get; set; }

        [Required]
        [Display(Name = "Havaalani Kodu")]
        [StringLength(3, MinimumLength = 3, ErrorMessage = "Lutfen 3 haneli havaalani kodunu giriniz")]
        public string Kod { get; set; }
    }
}
