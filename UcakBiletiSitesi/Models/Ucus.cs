using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UcakBiletiSitesi.Models
{
    public class Ucus
    {
        //Ucus Sinifi Olusturulacaktir

        [Key] public int UcusId { get; set; }

        [Required]
        [MaxLength(10)]
        public string? UcusNo { get; set; }

        [ForeignKey("Ucak")]
        public int UcakId {  get; set; }
        public Ucak? Ucak { get; set; }

        [ForeignKey("Nereden")]
        public int NeredenHavaalaniId { get; set; }
        public Havaalani? Nereden { get; set; }

        [ForeignKey("Nereye")]
        public int NereyeHavaalaniId { get; set; }
        public Havaalani? Nereye { get; set; }

        [Required] public DateTime Tarih {  get; set; }
    }
}
