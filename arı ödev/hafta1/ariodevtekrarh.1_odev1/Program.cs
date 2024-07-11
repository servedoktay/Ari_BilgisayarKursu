using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ariodevtekrarh._1_odev1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcının girdiği bir kelimenin alfabetik sıra numaralarını toplayan ve ekrana yazan programı yazınız. 
            string kelime;
            bool kontrol;

            do
            {
                Console.WriteLine("Bir Kelime Giriniz:");
                kelime = Console.ReadLine();
                kontrol = true; // Başlangıçta kontrol true olarak ayarlanır

                foreach (char kont in kelime)
                {
                    if (!char.IsLetter(kont) && kont != ' ')
                    {
                        Console.WriteLine($"Geçersiz karakter girdiniz: {kont}");
                        kontrol = false; // Geçersiz karakter bulunduğunda kontrol false yapılır
                        break; // Döngüyü sonlandır ve tekrar başa dön
                    }
                }

            } while (!kontrol); // Kontrol false olduğu sürece döngü devam eder

            Console.WriteLine("Giriş başarılı!");

            foreach (char harf in kelime)
            {
                int toplam = 0;
                char yenikarekter=char.ToLower(harf);
                if (char.IsLetter(harf) || harf == ' ')
                {

                    switch (yenikarekter)
                    {
                        case 'a':toplam = toplam + 1; break;
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
                        case 's': toplam = toplam + 21; break;
                        case 'ş': toplam = toplam + 23; break;
                        case 't': toplam = toplam + 24; break;
                        case 'u': toplam = toplam + 25; break;
                        case 'ü': toplam = toplam + 26; break;
                        case 'v': toplam = toplam + 27; break;
                        case 'y': toplam = toplam + 28; break;
                        case 'z': toplam = toplam + 29; break;
                      
                        case ' ': toplam = toplam + 0; break;
                        default:
                            Console.WriteLine("hata");
                            break;
                    }
                    

                }
                Console.WriteLine($"{kelime}= {toplam}");
            }
            Console.ReadKey();
        }
    }
}
