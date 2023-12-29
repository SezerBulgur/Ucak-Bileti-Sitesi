using System.ComponentModel.DataAnnotations;

namespace UcakBiletiSitesi.Models
{
    public class Yolcu : Kullanici
    {
        [Key] public int YolcuId { get; set; }

        [Required(ErrorMessage = "Lutfen isminizi yaziniz")]
        public string Ad { get; set; }

        [Required(ErrorMessage = "Lutfen soyisminizi yaziniz")]
        public string Soyad { get; set; }

        [Display(Name = "TC Kimlik Numarasi")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "Lutfen 11 haneli TC kimlik numaranizi giriniz")]
        public string KimlikNo { get; set; }

        public List<Bilet> Biletler = new List<Bilet>();
    }
}