using System.ComponentModel.DataAnnotations;

namespace UcakBiletiSitesi.Models
{
    public class Yolcu : Kullanici
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        [Display(Name = "TC Kimlik Numarasi")]
        public string KimlikNo { get; set; }
        public List<Bilet> Biletler = new List<Bilet>();
    }
}
