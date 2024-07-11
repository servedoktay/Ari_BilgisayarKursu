using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _06._07._2024_odev1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int boyut;
            Console.WriteLine("Dizi boyutu Giriniz");
            boyut = Convert.ToInt32(Console.ReadLine());
            string[] kelimeler = new string[boyut];
            int[] siranot = new int[boyut];
            bool kontrol = true;

            for (int i = 0; i < boyut; i++)
            {
                string a;
                do
                {
                    Console.WriteLine($"{i + 1}. kelimeyi giriniz:");
                    kelimeler[i] = Console.ReadLine();
                    kontrol = KarakterKont(kelimeler[i]);
                    if (kontrol == false)
                    {
                        Console.WriteLine("Geçersiz giriş. Lütfen tekrar deneyin.");
                    }
                } while (kontrol == false);

                
                siranot[i] = AlfSay(kelimeler[i]);
            }

            Console.WriteLine("\nKelimeler ve Puanları:\n");
            for (int i = 0; i < boyut; i++)
            {
                Console.WriteLine($"{kelimeler[i]}:   {siranot[i]}");
            }

            Console.ReadKey();
        }

        static bool KarakterKont(string kelime)
        {
            foreach (char karakter in kelime)
            {
                if (!char.IsLetter(karakter) && karakter != ' ')
                {
                    return false;
                }
            }
            return true;
        }

        static int AlfSay(string kelime)
        {
            int toplam = 0;
            foreach (char harf in kelime)
            {
               
                    char kucukharf = char.ToLower(harf);

                    switch (kucukharf)
                    {
                        case 'a': toplam++; break;
                        case 'b': toplam += 2; break;
                        case 'c': toplam += 3; break;
                        case 'ç': toplam += 4; break;
                        case 'd': toplam += 5; break;
                        case 'e': toplam += 6; break;
                        case 'f': toplam += 7; break;
                        case 'g': toplam += 8; break;
                        case 'ğ': toplam += 9; break;
                        case 'h': toplam += 10; break;
                        case 'ı': toplam += 11; break;
                        case 'i': toplam += 12; break;
                        case 'j': toplam += 13; break;
                        case 'k': toplam += 14; break;
                        case 'l': toplam += 15; break;
                        case 'm': toplam += 16; break;
                        case 'n': toplam += 17; break;
                        case 'o': toplam += 18; break;
                        case 'ö': toplam += 19; break;
                        case 'p': toplam += 20; break;
                        case 'r': toplam += 21; break;
                        case 's': toplam += 22; break;
                        case 'ş': toplam += 23; break;
                        case 't': toplam += 24; break;
                        case 'u': toplam += 25; break;
                        case 'ü': toplam += 26; break;
                        case 'v': toplam += 27; break;
                        case 'y': toplam += 28; break;
                        case 'z': toplam += 29; break;
                        case ' ': toplam += 0; break;
                        default:
                            Console.WriteLine("Hatali giris");
                            return 0;
                    }
                
            }
            return toplam;
        }
    }
}