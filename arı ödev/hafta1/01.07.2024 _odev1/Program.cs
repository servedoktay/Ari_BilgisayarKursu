using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._07._2024__odev1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir kelime giriniz:");
            string kelime = Console.ReadLine();

            bool? ilkUnluKalinMi = null;

            string kalinUnluler = "aıou";
            string inceUnluler = "eiöü";

            bool uyumlu = true;

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

        }
    }
}
