using Microsoft.AspNetCore.Mvc;

namespace Proje_OOP.Controllers
{
    public class DefaultController : Controller
    {
        void messages()
        {
            ViewBag.m1 = "Merhaba bu bir ASP.Net Core Projesidir.";
            ViewBag.m2 = "Starta Hoşgeldiniz.";

        }
        int topla()
        {
            int s1 = 10;
            int s2 = 20;
            int sonuc = s1 + s2;
            return sonuc;
        }
        string cumle()
        {
            string c = "Buda geriye değer döndüren string bir method";
            return c;
        }
        void MessagesList(string p)
        {
            ViewBag.v = p;
        }
        void Kullanıcı(string customerName)
        {
            ViewBag.name = customerName;
        }
        void PTopla(int s1, int s2)
        {
            int sayi1 = s1;
            int sayi2 = s2;
            int sonuc = sayi1 + sayi2;
            ViewBag.s = sonuc;
        }





        //**************************************************************---View---***************************************************************



        public IActionResult Index()
        {
            messages();
            MessagesList("Parametreli method denemesi");
            Kullanıcı("AHMET");
            return View();
        }
        public IActionResult Urunler()
        {
            Kullanıcı("MEHMET");
            ViewBag.c = cumle();
            ViewBag.t = topla();
            messages();
            return View();
        }
        public IActionResult Musteriler()
        {
            PTopla(10, 20);
            Kullanıcı("HAKAN");
            return View();
        }
    }
}
