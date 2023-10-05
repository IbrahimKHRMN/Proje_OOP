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
        public IActionResult Index()
        {
            messages();
            return View();
        }
    }
}
