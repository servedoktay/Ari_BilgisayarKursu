using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // bir hastanenin class yapısını oluşturunuz. Class içerisinde hastalar, doktorlar, hemşireler, hasta bilgileri, öğrenciler, çalışanlar, stajyerler gibi dataların tutulduğu bir yapıda olmalıdır. hasta miktarı, hastanın kullandığı ilaçlar gibi dataları da fonksiyon ile sorgulayabilmeliyiz.
           


        }

        class Hasta
        {
            public int Id { get; set; }
            public string hastaAdi { get; set; }            
            public DateTime girisTarihi { get; set; }
            public string cinsiyet { get; set; }

        }

        class hastaGirisleri
        {
            public int Id { get; set; }
            public Hasta HastaId { get; set; }
            public DateTime giristarihi { get; set; }
            public string bolumu { get; set; }
        }

        class Doktor
        {
            public int Id { get; set; }
            public DateTime iseGirisTarihi { get; set; }
            public string Brans { get; set; }
            public Hasta HastaId { get; set; }
        }
    }
} 
