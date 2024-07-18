using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ornek1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci yeniOgrenci = new Ogrenci();
            yeniOgrenci.Numara = "1";
            yeniOgrenci.adSoyad = "Ali Veli";
            yeniOgrenci.Okul = "Marmara";
            yeniOgrenci.Sinif = "A1";
            yeniOgrenci.Adres = "İstanbul";
            Console.WriteLine(yeniOgrenci.Numara);
            Console.ReadLine();


    }

        public class Ogrenci
        {
            public string Numara { get; set; }
            public string adSoyad { get; set; }
            public string Okul { get; set; }
            public string Sinif { get; set; }
            public string Adres { get; set; }            
            public DateTime dogumTarihi { get; set; }

        }
    }
}
