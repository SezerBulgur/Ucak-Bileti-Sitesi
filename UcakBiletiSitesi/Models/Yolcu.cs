using System.ComponentModel.DataAnnotations;

namespace UcakBiletiSitesi.Models
{
    public class Yolcu : Kullanici
    {
        [Key] public string YolcuId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        [Display(Name = "TC Kimlik Numarasi")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "Lutfen 11 haneli TC kimlik numaranizi giriniz")]
        public string KimlikNo { get; set; }
        public List<Bilet> Biletler = new List<Bilet>();
    }
}