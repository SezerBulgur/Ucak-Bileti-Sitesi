using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UcakBiletiSitesi.Models;

namespace UcakBiletiSitesi.Controllers
{
    public class HomeController : Controller
    {
        IVeritabani Veritabani = new SanalVeritabani();


        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public string Kaydet(Yolcu yolcu)
        {
            Veritabani.YolcuEkle(yolcu);
            string txt = yolcu.Email + " email adresine sahip kullanici kaydedildi";
            return txt;      
        }

        /*
        [HttpPost]
        public IActionResult Dogrula(Yolcu yolcu)
        {
            if (Veritabani.YolcuDogrula(yolcu))
            {
                //deneme olarak olusturulan bilet yolcuya aktarilmasi
                Bilet b = new Bilet(yolcu);


                HttpContext.Session.SetString("SessionUser", yolcu.Email);
                return View("Deneme", yolcu);
            }
            ViewBag.Hata = "Hatali giris yapildi. Lutfen tekrar deneyiniz";
            return View("Index");
        }
        */
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}