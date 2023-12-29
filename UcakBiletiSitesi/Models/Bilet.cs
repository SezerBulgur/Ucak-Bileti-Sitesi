using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UcakBiletiSitesi.Models
{
    public class Bilet
    {
        [Key] public int BiletId { get; set; }

        [ForeignKey("Yolcu")]
        public int YolcuId { get; set; }
        public Yolcu? Yolcu { get; set; }

        [ForeignKey("Ucus")]
        public int UcusId { get; set; }
        public Ucus? Ucus { get; set; }

        /*
        public string deneme { get; set; }
        public Bilet(Yolcu y) 
        {
            yolcu = y;
            deneme = "bu bir deneme biletidir";
            yolcu.Biletler.Add(this);
        }
        */
    }
}
