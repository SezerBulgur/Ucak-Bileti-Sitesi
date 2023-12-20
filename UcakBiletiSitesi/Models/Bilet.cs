namespace UcakBiletiSitesi.Models
{
    public class Bilet
    {
        public Yolcu yolcu { get; set; }
        public string deneme { get; set; }
        public Bilet(Yolcu y) 
        {
            yolcu = y;
            deneme = "bu bir deneme biletidir";
            yolcu.Biletler.Add(this);
        }
    }
}
