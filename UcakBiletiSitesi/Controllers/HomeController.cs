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

        [HttpPost]
        public string Dogrula(Yolcu yolcu)
        {
            string txt = "sisteme giris yapialamadi tekrar deneyiniz";
            if (Veritabani.YolcuDogrula(yolcu))
            {
                txt = yolcu.Email + " sisteme basari ile giris yapti";
            }
            
            return txt;
        }
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