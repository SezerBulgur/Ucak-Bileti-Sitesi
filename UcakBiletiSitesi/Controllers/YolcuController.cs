using Microsoft.AspNetCore.Mvc;
using UcakBiletiSitesi.Models;

namespace UcakBiletiSitesi.Controllers
{
    public class YolcuController : Controller
    {
        IVeritabani Veritabani = new SanalVeritabani();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult KayitOl()
        {
            return View();
        }

        public IActionResult GirisYap() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult Dogrula(Yolcu yolcu)
        {
            if (Veritabani.YolcuDogrula(yolcu))
            {
                //deneme olarak olusturulan bilet yolcuya aktarilmasi
                Bilet b = new Bilet(yolcu);


                HttpContext.Session.SetString("SessionUser", yolcu.Email);
                return View("../Home/Deneme", yolcu);
            }
            ViewBag.Hata = "Hatali giris yapildi. Lutfen tekrar deneyiniz";
            return View("GirisYap");
        }
    }
}
