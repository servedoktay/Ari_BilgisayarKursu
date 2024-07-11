using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._07._2024_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //class olusturmak ve prop

            //ogrenci yeni = new ogrenci();
            //yeni.Numara = "1";
            //yeni.adSoyad = "oktay";
            //yeni.okul = "ataşehir";
            //yeni.sinif = "2";
            //yeni.adres = "istanbul";
            //yeni.det = new DateTime(1998, 10, 26);

            //okul yOkul=new okul();
            //yOkul.ad = "Ankara";
            //Console.WriteLine();
            //yOkul.adSoyadYaz();

            

            Console.ReadKey();
        }
        public  class ogrenci
        {
            public string Numara { get; set; }
            public string adSoyad { get; set; }
            public string okul { get; set; }
            public string sinif { get; set; }
            public string adres{ get; set; }            
            public DateTime det { get; set; }
        }
        public class okul
        {
            public string ad { get; set; }
            public string adres { get; set; }
            public string mudurAd { get; set; }
            public DateTime kurulusT { get; set; }
            public int ogrenciMev { get; set; }
            public int ogretmenMev { get; set; }

            public void adSoyadYaz() 
            {
                Console.WriteLine(ad);
            }
        }
    }
}
