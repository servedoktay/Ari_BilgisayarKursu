using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3 - Kullanıcının girdiği 2 yazılı ve 1 sözlü notu ile öğrencinin ortalamasını hesaplayan programı yazınız.

            int yaz1, yaz2, soz1;
            double ortalama;

            Console.WriteLine("1. yazılıyı gir");
            yaz1 = int.Parse(Console.ReadLine());

            Console.WriteLine("2. yazılıyı gir");
            yaz2 = int.Parse(Console.ReadLine());

            Console.WriteLine("1. sözlüyü gir");
            soz1 = int.Parse(Console.ReadLine());

            ortalama = (yaz1 + yaz2 + soz1) / 3;

            Console.WriteLine("Ortalama = " + ortalama);

            Console.ReadLine();

        }
    }
}
