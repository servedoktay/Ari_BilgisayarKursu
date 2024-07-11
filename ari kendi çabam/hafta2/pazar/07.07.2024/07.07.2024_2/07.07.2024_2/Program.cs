using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _07._07._2024_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bir mağazanın datalarını tutabilecek bir class olusturunuz.Bu class icersinde musteri,satislar,stoklar,personeller gibi datalar tutulmaktadır,
            //Fonksiyon ile depoda ne kadar urun var bugun ne kadar t tariinde ne kadr satıldı hangi personel ne kadr urun sattı gibi degerlerin fonksiyon uzerınden donmesı beklenmektedir
            Musteri m1 = new Musteri();
            Musteri m2 = new Musteri();

            m1.AdSoyad = "müsteri1";
            m1.MusteriID = 0;

            m2.AdSoyad = "musteri2";
            m2.MusteriID = 1;

            Personel p1 = new Personel();
            Personel p2 = new Personel();

            p1.PersonelAd = "personel1";
            p1.PersonelID = 0;

            p2.PersonelAd = "personel2";
            p2.PersonelID = 1;

            Urun u1 = new Urun();
            Urun u2 = new Urun();

            u1.UrunAdi = "urun1";
            u1.UrunID = 0;
            u1.StokAdedi = 500;

            u2.UrunAdi = "urun2";
            u2.UrunID = 1;
            u2.StokAdedi = 300;

            Satis s1 = new Satis();
            Satis s2 = new Satis();

            s1.SatisID = 0;
            s1.Tarih = new DateTime(1998, 10, 26);
            s1.PersonelID = p2; 
            s1.UrunID = u1;    
            s1.MusteriID = m2;  
            int ist1 = 5;
            if (u1.StokAdedi - ist1 > 0)
            {
                s1.Adet = ist1;
                u1.StokAdedi -= ist1;
            }
            else
            {
                s1.Adet = 0;
                u1.StokAdedi -= ist1;
            }

            s2.SatisID = 1; 
            s2.Tarih = new DateTime(1998, 10, 26);
            s2.PersonelID = p2; 
            s2.UrunID = u2;     
            s2.MusteriID = m1;  
            int ist2 = 5;
            if (u2.StokAdedi - ist2 > 0)
            {
                s2.Adet = ist2;
                u1.StokAdedi -= ist1;
            }
            else
            {
                s2.Adet = 0;
                u1.StokAdedi -= ist1;
            }

            Console.WriteLine("Satis 1:");
            Console.WriteLine($"Satis ID: {s1.SatisID}");
            Console.WriteLine($"Tarih: {s1.Tarih}");
            Console.WriteLine($"Personel: {s1.PersonelID.PersonelAd}");
            Console.WriteLine($"Musteri: {s1.MusteriID.AdSoyad}");
            Console.WriteLine($"Urun: {s1.UrunID.UrunAdi}");
            Console.WriteLine($"Adet: {s1.Adet}");

            Console.WriteLine("\nSatis 2:");
            Console.WriteLine($"Satis ID: {s2.SatisID}");
            Console.WriteLine($"Tarih: {s2.Tarih}");
            Console.WriteLine($"Personel: {s2.PersonelID.PersonelAd}");
            Console.WriteLine($"Musteri: {s2.MusteriID.AdSoyad}");
            Console.WriteLine($"Urun: {s2.UrunID.UrunAdi}");
            Console.WriteLine($"Adet: {s2.Adet}");

            Console.WriteLine("sorgu no");
            u1.stokdurumu(u1.UrunID);
           

            Console.ReadKey();
        }
    }

    class Musteri
    {
        public int MusteriID { get; set; }
        public string AdSoyad { get; set; }
        public DateTime KayitT { get; set; }
    }

    class Satis
    {
        public int SatisID { get; set; }
        public DateTime Tarih { get; set; }
        public Personel PersonelID { get; set; }
        public Musteri MusteriID { get; set; }
        public Urun UrunID { get; set; }
        public int Adet { get; set; }
    }

    public class Urun
    {
        public int UrunID { get; set; }
        public string UrunAdi { get; set; }
        public int StokAdedi { get; set; }

        public int stokdurumu(int sorgu)
        {
            if (UrunID==sorgu)
            {
                Console.WriteLine(StokAdedi);
            }
            
            return StokAdedi;
        }

    }

    class Personel
    {
        public int PersonelID { get; set; }
        public string PersonelAd { get; set; }
    }

}


