using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ariodevtekrarh._1_odev2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //string kelime;
            //string kalinUnluler = "aıou";
            //string inceUnluler = "eiüö";
            //bool? ilkUnlukalin = null;
            //bool? ilkUnluInce = null;
            //bool uyumlu = true;
            //bool karakterkont;
            //do
            //{
            //    karakterkont = true;
            //    Console.WriteLine("Bir Kelime Giriniz..:");
            //    kelime = Console.ReadLine();
            //    foreach (char karakter in kelime)
            //    {
            //        if (!char.IsLetter(karakter) || karakter == ' ')
            //        {
            //            Console.WriteLine($"Geçersiz karakter girdiniz: {karakter}");
            //            karakterkont = false;
            //            break;
            //        }

            //    }

            //} while (!karakterkont);

            //Console.WriteLine("Kelime Kosullara Uygun\n");

            //for (int i = 0; i < kelime.Length; i++)
            //{
            //    char harf = char.ToUpper(kelime[i]);
            //    if (kalinUnluler.Contains(harf)) 
            //    {
            //        if (ilkUnlukalin==null)
            //        {
            //            ilkUnlukalin = true;
            //        }
            //        else if (ilkUnlukalin == false)
            //        {
            //            uyumlu = false;
            //            break;
            //        }

            //    }
            //    else if (inceUnluler.Contains(harf))
            //    {
            //        if (ilkUnluInce == null)
            //        {
            //            ilkUnlukalin = false;
            //        }
            //        else if (ilkUnluInce == true)
            //        {
            //            uyumlu = false;
            //            break;
            //        }

            //    }

            //}
            //if (uyumlu)
            //{
            //    Console.WriteLine("buyuk unlu uyumlu");
            //}
            //else Console.WriteLine("yok");
            string kelime;
            bool? ilkUnluKalinMi = null;

            string kalinUnluler = "aıou";
            string inceUnluler = "eiöü";

            bool uyumlu = true;
            bool karakterkont;
            do
            {
                karakterkont = true;
                Console.WriteLine("Bir Kelime Giriniz..:");
                kelime = Console.ReadLine();
                foreach (char karakter in kelime)
                {
                    if (!char.IsLetter(karakter) || karakter == ' ')
                    {
                        Console.WriteLine($"Geçersiz karakter girdiniz: {karakter}");
                        karakterkont = false;
                        break;
                    }

                }

            } while (!karakterkont);

            Console.WriteLine("Kelime Kosullara Uygun\n");

            for (int i = 0; i < kelime.Length; i++)
            {
                char harf = kelime[i];

                if (kalinUnluler.Contains(harf))
                {
                    if (ilkUnluKalinMi == null)
                    {
                        ilkUnluKalinMi = true;
                    }
                    else if (ilkUnluKalinMi == false)
                    {
                        uyumlu = false;
                        break;
                    }
                }
                else if (inceUnluler.Contains(harf))
                {
                    if (ilkUnluKalinMi == null)
                    {
                        ilkUnluKalinMi = false;
                    }
                    else if (ilkUnluKalinMi == true)
                    {
                        uyumlu = false;
                        break;
                    }
                }
            }
            if (uyumlu)
            {
                Console.WriteLine("Bu kelime büyük ünlü uyumuna uymaktadır.");
            }
            else
            {
                Console.WriteLine("Bu kelime büyük ünlü uyumuna uymamaktadır.");
            }


            Console.ReadKey();

            Console.ReadKey();

        }
    }
}
