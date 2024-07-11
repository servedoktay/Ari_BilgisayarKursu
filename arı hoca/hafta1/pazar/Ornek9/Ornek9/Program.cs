using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcının girdiği bir sayının asal olup olmadığını bulan programı yazınız.

            int sayi;
            Console.WriteLine("Sayı Gir");
            sayi = int.Parse(Console.ReadLine());

            int durum = 0;

            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i==0)
                {
                    durum = 1;
                }                
            }

            if (durum==0)
            {
                Console.WriteLine("Sayı asaldır");
            }
            else
            {
                Console.WriteLine("Sayı asal değildir");
            }

            Console.ReadLine();
        }
    }
}
