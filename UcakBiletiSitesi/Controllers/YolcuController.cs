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
        public IActionResult Dogrula(Kullanici y)
        {
            if (ModelState.IsValid) 
            {
                Yolcu yolcu = Veritabani.YolcuDogrula(y);
                if (yolcu != null)
                {
                    //deneme olarak olusturulan bilet yolcuya aktarilmasi
                    //Bilet b = new Bilet(yolcu);


                    HttpContext.Session.SetString("SessionUser", yolcu.Email);
                    return View("Bilgi", yolcu);
                }
                
            }
            ViewBag.Hata = "Hatali giris yapildi. Lutfen tekrar deneyiniz";
            return View("GirisYap");
        }
    }
}
