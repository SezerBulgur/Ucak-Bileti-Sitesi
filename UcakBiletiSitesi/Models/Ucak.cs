using System.ComponentModel.DataAnnotations;

namespace UcakBiletiSitesi.Models
{
    public class Ucak
    {
        [Key] public int UcakId { get; set; }

        public string Model { get; set; }

        //koltuk duzeni olusturulacak
    }
}
