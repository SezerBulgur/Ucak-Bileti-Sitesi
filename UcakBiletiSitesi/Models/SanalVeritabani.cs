namespace UcakBiletiSitesi.Models
{
    public class SanalVeritabani : IVeritabani
    {
        private List<Yolcu> Yolcular = new List<Yolcu>()
        {
            new Yolcu(){Ad = "Sezer", Soyad = "Bulgur", KimlikNo = "1", Email = "sb@mail.com", Password = "123" }
        };
        private List<Admin> Adminler = new List<Admin>();
        private List<Ucak> Ucaklar = new List<Ucak>();
        private List<Ucus> Ucuslar = new List<Ucus>();

        public bool AdminDogrula(Admin admin)
        {
            //Admin Dogrulama Islemi Yapilacak
            throw new NotImplementedException();
        }

        public void AdminEkle(Admin admin)
        {
            //Admin Ekleme Islemi Yapilacak
            throw new NotImplementedException();
        }

        public void AdminSil(Admin admin)
        {
            //Admin Silme Islemi Yapilacak
            throw new NotImplementedException();
        }

        public void UcakEkle(Ucak ucak)
        {
            //Ucak Modeli Eklenecek
            throw new NotImplementedException();
        }

        public void UcakSil(Ucak ucak)
        {
            //Ucak Modeli Silme Islemi
            throw new NotImplementedException();
        }

        public void UcusEkle(Ucus ucus)
        {
            //Planlanan Ucuslar Eklenecek
            throw new NotImplementedException();
        }

        public void UcusSil(Ucus ucus)
        {
            //Iptal Edilen Ucuslarin Silinmesi
            throw new NotImplementedException();
        }

        public Yolcu? YolcuDogrula(Kullanici _yolcu)
        {
            foreach (var yolcu in Yolcular) 
            {
                if (yolcu.Email == _yolcu.Email && yolcu.Password == _yolcu.Password)
                {
                    return (Yolcu?)yolcu;
                }
            }
            return null;
        }

        
        public void YolcuEkle(Yolcu yolcu)
        {
            
            throw new NotImplementedException();
            /*
            if (YolcuDogrula(yolcu))
            {
                Console.WriteLine("Yolcu zaten ekli");
            } else 
            {
                Console.WriteLine("Yolcu ekleniyor...");
            }
            */
        }

        public void YolcuSil(Yolcu yolcu)
        {
            throw new NotImplementedException();
        }
    }
}
