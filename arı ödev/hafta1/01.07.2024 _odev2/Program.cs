using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._07._2024__odev2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> harfSayiKarsiligi = new Dictionary<char, int>
            {
                { 'a', 1 }, { 'b', 2 }, { 'c', 3 }, { 'ç', 4 },
                { 'd', 5 }, { 'e', 6 }, { 'f', 7 }, { 'g', 8 },
                { 'ğ', 9 }, { 'h', 10 }, { 'ı', 11 }, { 'i', 12 },
                { 'j', 13 }, { 'k', 14 }, { 'l', 15 }, { 'm', 16 },
                { 'n', 17 }, { 'o', 18 }, { 'ö', 19 }, { 'p', 20 },
                { 'r', 21 }, { 's', 22 }, { 'ş', 23 }, { 't', 24 },
                { 'u', 25 }, { 'ü', 26 }, { 'v', 27 }, { 'y', 28 },
                { 'z', 29 }
            };

            Console.WriteLine("Bir kelime giriniz:");
            string kelime = Console.ReadLine(); 

            int toplam = 0; 

            foreach (char harf in kelime)
            {
                
                char kucukHarf = char.ToLower(harf);

                if (harfSayiKarsiligi.ContainsKey(kucukHarf))
                {
                    toplam += harfSayiKarsiligi[kucukHarf];
                }
            }

           
            Console.WriteLine("Kelimenin alfabedeki sayı karşılıklarının toplamı: " + toplam);
            Console.ReadKey();
        }
    }
}
