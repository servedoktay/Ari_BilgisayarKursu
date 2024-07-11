using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._07._2024_ders3
{
    internal class Program
    {


        static void Main(string[] args)
        {
            //forIleUsAlma();          
            //orn2();
            //orn3();
            //basitfonksiyontanimlama();
            //mathKutuphanesiOrn();


            //KULLANİCİNin girdigi 2 sayi sayi arasındaki asal sayilari giren fonksiyonu yazıniz

            int s1, s2;
            Console.WriteLine("2 Sayi Giriniz ");
            s1 = Convert.ToInt32(Console.ReadLine());
            s2 = Convert.ToInt32(Console.ReadLine());
            asalMi(s1, s2);

            Console.ReadKey();

        }
        static void asalMi(int s1,int s2)
        {
            int enb, enk;
           
            if (s1!=s2)
            {
                enk = Math.Min(s1, s2);
                enb = Math.Max(s1, s2); 
                Console.WriteLine($"{enb} ile {enk} sayi arasındaki asal sayilar");
                for (int i = enk; i < enb; i++)
                {
                    bool durum = false;
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j ==0 )
                        {
                            durum = true;
                        }
                    }
                    if (durum == true)
                    {

                    }
                    else
                    {
                        Console.Write(i + ",");
                    }
                }
            
            }
            else
            {
                Console.WriteLine("Sayilar Esit Olamaz");
            }

            
         

        }

        private static void mathKutuphanesiOrn()
        {
            //math kutuphanesi
            Console.WriteLine(Math.Pow(4, 3)); //üs
            Console.WriteLine(Math.PI); //pi
            Console.WriteLine(Math.E); //e sayisi
            Console.WriteLine(Math.Max(13, 14)); //2 sayidan buyuk olanı bul
            Console.WriteLine(Math.Min(13, 14)); //3 sayidan buyuk olani bul
            Console.WriteLine(Math.Abs(-17)); //mutlak deger
        }

        private static void basitfonksiyontanimlama()
        {
            //fonksiyon tanimlama :
            topla(8, 9);
            topla(10, 9);
            topla(8, 900);
            cikar(82, 93);
            cikar(855, 95);
            cikar(8123, 9434);
            carp(21218, 93434);
            bol(823232, 93232);
        }

        static void bol(int s1, int s2)
        {
            if (s2 !=0)
            {
                int sonuc = s1 / s2;
                Console.WriteLine(sonuc);
            }
            else if (s2 ==0)
            {
                Console.WriteLine("2.sayi 0 Olamaz");
            }
            
        }
        static void carp(int s1, int s2)
        {
            int sonuc = s1 * s2;
            Console.WriteLine(sonuc);
        }
        static void cikar(int s1,int s2)
        {
            int sonuc = s1 - s2;
            Console.WriteLine(sonuc);
        }
        static void topla(int sayi1,int sayi2)
        {
            int toplam = toplam = sayi1 + sayi2;
            Console.WriteLine(sayi1+sayi2);
        }

        private static void orn3()
        {
            //kullanıcının gırdıgı 1 ile 12 arasındaki sayiya gore hangi ayın old ekrana yazan program
            Console.WriteLine("1-ile 12 Arasında Deger gir");
            if (int.TryParse(Console.ReadLine(), out int ay))
            {
                switch (ay)
                {
                    case 1: Console.WriteLine("Ocak"); break;
                    case 2: Console.WriteLine("Subat"); break;
                    case 3: Console.WriteLine("Mart"); break;
                    case 4: Console.WriteLine("Nisan"); break;
                    case 5: Console.WriteLine("Mayis"); break;
                    case 6: Console.WriteLine("Haziran"); break;
                    case 7: Console.WriteLine("Temmuz"); break;
                    case 8: Console.WriteLine("Ağustos"); break;
                    case 9: Console.WriteLine("Eylul"); break;
                    case 10: Console.WriteLine("Ekim"); break;
                    case 11: Console.WriteLine("Kasim"); break;
                    case 12: Console.WriteLine("Aralik"); break;
                    default: Console.WriteLine($"Hatali Giris  \nTanimlanan Aralikta Degil:{ay}"); break;
                }
            }
            else Console.WriteLine("Rakam  Girmediniz");
        }

        private static void orn2()
        {
            //while ile 10 kez merhaba yazmak
            int sayac = 0;
            while (sayac < 10)
            {
                Console.WriteLine("Merhaba");
                sayac++;
            }
        }

        private static void forIleUsAlma()
        {
            //orn1:
            //kullanıcının gırdıgı us ve taban bılgısıne gore gırılen sayinin ussunu hesaplayın
            int taban, us, sonuc;
           
            Console.WriteLine("taban:");
            taban = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("us:");
            us = Convert.ToInt32(Console.ReadLine());

            sonuc = 1;
            for (int i = 0; i < us; i++)
            {
                sonuc *= taban;
            }
            Console.WriteLine($"{taban} sayisinin {us} u kuveetinin alımının sonucu ={sonuc} ");

            /*
            Math.Pow(taban,us);
            Console.WriteLine(sonuc)
            Console.Readline();*/
        }
    }
}
