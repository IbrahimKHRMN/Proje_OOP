using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.SqlServer.Migrations.Internal;
using Proje_OOP.Ornekler;

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
        public IActionResult Deneme()
        {
            Sehirler sehirler = new Sehirler();
            sehirler.ID = 2;
            sehirler.SehirAdı = "Malatya";
            sehirler.Nufus = 1200000;
            sehirler.Ulke = "Türkiye";
            sehirler.Renk1 = "Kırmızı";
            sehirler.Renk2 = "Beyaz";

            ViewBag.s1 = sehirler.ID;
            ViewBag.s2 = sehirler.Ulke;
            ViewBag.s3 = sehirler.SehirAdı;
            ViewBag.s4 = sehirler.Nufus;
            ViewBag.s5 = sehirler.Renk1 + sehirler.Renk2 + sehirler.Renk3;

            sehirler.ID = 3;
            sehirler.SehirAdı = "Antep";
            sehirler.Nufus = 1400000;
            sehirler.Ulke = "Türkiye";
            sehirler.Renk1 = "Kırmızı";
            sehirler.Renk2 = "Beyaz";

            ViewBag.z1 = sehirler.ID;
            ViewBag.z2 = sehirler.Ulke;
            ViewBag.z3 = sehirler.SehirAdı;
            ViewBag.z4 = sehirler.Nufus;
            ViewBag.z5 = sehirler.Renk1 + sehirler.Renk2 + sehirler.Renk3;

            return View();
        }
    }
}


