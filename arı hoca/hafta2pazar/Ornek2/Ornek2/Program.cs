using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Okul yeniOkul = new Okul();
            yeniOkul.Adi = "Kadıköy Anadolu";

            yeniOkul.adSoyadYaz();           

        }
        public class Okul
        {
            public string Adi { get; set; }
            public string Adres { get; set; }
            public string MudurAdSoyad { get; set; }
            public DateTime kurulusTarihi { get; set; }
            public int OgrenciMevcudu { get; set; }
            public int OgretmenMevcudu { get; set; }

            public void adSoyadYaz()
            {
                Console.WriteLine(Adi);
            
            }
        }

    }
}
