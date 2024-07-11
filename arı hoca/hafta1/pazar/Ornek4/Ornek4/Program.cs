using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcının girdiği 10 sayının ortalamasını bulan programı yazınız.

            int toplam,sayi;
            toplam = 0;
            double ort;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Sayı gir");
                sayi = int.Parse(Console.ReadLine());
                toplam = toplam + sayi;
            }

            ort = toplam / 10;

            Console.WriteLine(ort.ToString());
            Console.ReadLine();

        }
    }
}
