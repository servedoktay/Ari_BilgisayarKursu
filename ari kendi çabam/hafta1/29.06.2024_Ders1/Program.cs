using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //29.06.2024 ders 1

            //orn1();
            //orn2();
            //orn3();
            //orn4();
            //orn5(); 
            //orn6();
            //orn7();
            //orn8();

            //kullanıcının girdigi 2 sayıdan buyuk olanı ekrana yazan programı ekrana yazınız
            
            int sayi, sayi2;
            Console.WriteLine("s1..:");
            sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("s2..:");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            if (sayi >sayi2)
            {
                Console.WriteLine("Sayi 1 buyuktur..:"+sayi);
            }
            else if (sayi2>sayi)
            {
                Console.WriteLine("Sayi 2 Buyuktur..:"+sayi2);
            }
            else Console.WriteLine("Sayilar Esittir");
            Console.ReadLine();
        }

        private static void orn8()
        {
            //kullanıcının gırdıgı sayılar ıle ucgenın alanı ve cevresını hesaplayan progrm
            int a, b, c, alan, cevre;

            Console.WriteLine("Ücgenın Kenarını giriniz");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ücgenın Kenarını giriniz");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ücgenın Kenarını giriniz");
            c = Convert.ToInt32(Console.ReadLine());

            cevre = a + b + c;
            

            Console.WriteLine("yukseklik");
            int y = Convert.ToInt32(Console.ReadLine());
            alan = c * y / 2;
            Console.WriteLine("Ucgenın Alanı..:" + alan);
            Console.WriteLine(cevre);


            Console.ReadLine();
        }

        private static void orn7()
        {
            //kullanıcının gırdıgı sayının kupunu hesaplayan program
            Console.WriteLine("Sayi Giriniz..:");
            int sayi = Convert.ToInt32(Console.ReadLine());

            int kup = sayi * sayi * sayi;
            Console.WriteLine("Sayinin Kupu..:" + kup);

            Console.ReadLine();
        }

        private static void orn6()
        {
            //bir ogrencının 3 yazılı ve sozlu notonu kullanıcıdan isteyip ortalamasını hesaplayan program
            int s1, s2, s3, soz;
            double ort;

            Console.WriteLine("1.sınav");
            s1 = int.Parse(Console.ReadLine());
            Console.WriteLine("2.sınav");
            s2 = int.Parse(Console.ReadLine());
            Console.WriteLine("3.sınav");
            s3 = int.Parse(Console.ReadLine());
            Console.WriteLine("sozlu..:");
            soz = int.Parse(Console.ReadLine());

            ort = (s1 + s2 + s3 + soz) / 4;
            Console.WriteLine("Ort..:" + ort);

            Console.ReadLine();

        }

        private static void orn5()
        {
            //kullanıcıdan alılan degerler ıle dıkdortgen ve karenın alanını ve cevresini hesaplayan kod
            int dKısakenar, dUzunKenar, dAlan, DCevre, kKenar, kAlan, kCevre;

            Console.WriteLine("Dikdortgen Uzun kenarı giriniz");
            dUzunKenar = int.Parse(Console.ReadLine());
            Console.WriteLine("Dikdortgen Kısa kenarı giriniz");
            dKısakenar = int.Parse(Console.ReadLine());

            Console.WriteLine("Kare kenarı giriniz");
            kKenar = int.Parse(Console.ReadLine());

            kAlan = kKenar * kKenar;
            kCevre = 4 * kKenar;
            DCevre = 2 * (dKısakenar + dUzunKenar);
            dAlan = dKısakenar * dUzunKenar;

            Console.WriteLine("KareAlanı..:" + kAlan);
            Console.WriteLine("Kare Cevre..:" + kCevre);
            Console.WriteLine("DikAlanı..:" + DCevre);
            Console.WriteLine("DikCevre..:" + dAlan);


            Console.ReadLine();

        }

        private static void orn4()
        {
            //orn4 kullanıcının gırdıgı 2 sayıyı toplayan cıkaran carpan bolen program
            int sayi1, sayi2;
            Console.WriteLine("1.sayiyi giriniz");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.sayiyi giriniz");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Sayiların Toplamı..:",sayi1+sayi2);
            int toplam, cıkar, carp;
            double bol;
            toplam = sayi1 + sayi2;
            cıkar = sayi1 - sayi2;
            carp = sayi1 * sayi2;
            if (sayi2 != 0)
            {
                bol = sayi1 / sayi2;
                Console.WriteLine("Toplam..:" + toplam + "\nCıkartma..:" + cıkar + " \nÇarp..:" + carp + " \nBol..:" + bol);
            }
            else Console.WriteLine("Toplam..:" + toplam + "\nCıkartma..:" + cıkar + " \nÇarp..:" + carp + " \nBol..:Bolme İşlemi Gerceklesmez 2.sayı 0 olamaz");
            Console.ReadLine();
        }

        private static void orn3()
        {
            //ORN 3 tanımlanan degiskenleri toplar

            int a, b, c, d, e;

            a = 1;
            b = 2;
            c = 3;
            d = 4;
            e = 5;

            Console.WriteLine(a + b + c + d + e);
            Console.ReadLine();
        }

        private static void orn2()
        {
            //ORN 2

            int a = 13;
            Console.WriteLine(a); //int deger yazar
            Console.WriteLine("a"); //string deger yazar
            Console.ReadLine();
        }

        private static void orn1()
        {
           // merhaba yazan program
            Console.WriteLine("merhaba"); //string veri
            Console.WriteLine(9 + 3); //parantez icinde olmayan matematiksel işlem 
            Console.WriteLine(9 * 3); //parantez icinde olmayan matematiksel işlem
            Console.WriteLine("9*3"); //parantez ici string veridir ekran cıktısı 9*3
            Console.ReadLine();
        }
    }
}
