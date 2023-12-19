namespace UcakBiletiSitesi.Models
{
    public interface IVeritabani
    {
        public bool YolcuDogrula(Yolcu yolcu);
        public void YolcuEkle(Yolcu yolcu);
        public void YolcuSil(Yolcu yolcu);
        public bool AdminDogrula(Admin admin);
        public void AdminEkle(Admin admin);
        public void AdminSil(Admin admin);
        public void UcusEkle(Ucus ucus);
        public void UcusSil(Ucus ucus);
        public void UcakEkle(Ucak ucak);
        public void UcakSil(Ucak ucak);

    }
}
