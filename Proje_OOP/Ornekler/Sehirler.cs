using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Razor;

namespace Proje_OOP.Ornekler
{
    public class Sehirler : Bayrak
    {
        Bayrak bayrak = new Bayrak();
        public int ID { get; set; }
        public string SehirAdı { get; set; }
        public int Nufus { get; set; }
        public string Ulke { get; set; }
    }
}
