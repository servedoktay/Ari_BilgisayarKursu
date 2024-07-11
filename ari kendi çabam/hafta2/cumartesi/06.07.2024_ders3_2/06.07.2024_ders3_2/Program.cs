using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _06._07._2024_ders3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //diziler
            //basitdizi();
            orn8();
            //boyutunu ve elemanlarını kullanıcının belirledigi string bir dizinin içeresinde bulunan elamanları alfabetik sıra numaraların toplamının ekrana yazdıran fonksiyon

            //boyununu ve elemanlarını kullanıcının belirledigi 2 boyutlu int dizi tanımlaynızınz
            //elemanların rasgele degerler olarak otomatik verilmesini saglayınız elemanların toplamını ekrana yazdırınız
            Console.WriteLine("Dizi Eleman Sayisini Giriniz");
            int elemans = Convert.ToInt32(Console.ReadLine());

            string[] dizi = new string[elemans];
            int[] alftoplam=new int[elemans];
            for (int i = 0; i < elemans; i++)
            {
                
                Console.WriteLine("Eleman Giriniz");
                dizi[i] = Console.ReadLine();
                foreach (char harf in dizi[i])
                {
                    char kucukharf = char.ToLower(harf);
                    int toplam = 0;
                    switch (kucukharf)
                    {

                        case 'a':toplam=toplam+1; break;
                        case 'b': toplam = toplam + 2; break;
                        case 'c': toplam = toplam + 3; break;
                        case 'ç': toplam = toplam + 4; break;
                        case 'd': toplam = toplam + 5; break;
                        case 'e': toplam = toplam + 6; break;
                        case 'f': toplam = toplam + 7; break;
                        case 'g': toplam = toplam + 8; break;
                        case 'ğ': toplam = toplam + 9; break;
                        case 'h': toplam = toplam + 10; break;
                        case 'ı': toplam = toplam + 11; break;
                        case 'i': toplam = toplam + 12; break;
                        case 'j': toplam = toplam + 13; break;
                        case 'k': toplam = toplam + 14; break;
                        case 'l': toplam = toplam + 15; break;
                        case 'm': toplam = toplam + 16; break;
                        case 'n': toplam = toplam + 17; break;
                        case 'o': toplam = toplam + 18; break;
                        case 'ö': toplam = toplam + 19; break;
                        case 'p': toplam = toplam + 20; break;
                        case 'r': toplam = toplam + 21; break;
                        case 's': toplam = toplam + 22; break;
                        case 'ş': toplam = toplam + 23; break;
                        case 't': toplam = toplam + 24; break;
                        case 'u': toplam = toplam + 25; break;
                        case 'ü': toplam = toplam + 26; break;
                        case 'v': toplam = toplam + 27; break;
                        case 'y': toplam = toplam + 28; break;
                        case 'z': toplam = toplam + 29; break;

                        default:
                            Console.WriteLine("hata");
                            break;
                    }
                    
                }

                
            }

            //Console.ReadKey();
        }

        private static void orn8()
        {
            //orn8:boyutunu ve elemanlarını kullanıcın belirledigi bir dizi olusturunuz kucukten buyuge sıralayınız ve ortalamasını yazdırınız
            Console.WriteLine("Dizi eleman Sayisi Giriniz");
            int elemans = Convert.ToInt32(Console.ReadLine());
            int[] sayilar = new int[elemans];
            int toplam = 0;
            int ort;
            for (int i = 0; i < elemans; i++)
            {
                Console.Write("Sayi Girin:");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
                toplam += sayilar[i];
            }
           
            Console.WriteLine(sayilar);


            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.Write(sayilar[i] + ",");
            }

            Console.WriteLine();
            ort = toplam / elemans;
            Console.WriteLine(ort);
        }

        private static void basitdizi()
        {
            int a = 5;
            int[] dizi = new int[10];
            dizi[0] = 8;
            dizi[2] = 10;
            Console.WriteLine(a);
            Console.WriteLine(dizi[0] + dizi[2]);
        }
    }
}
