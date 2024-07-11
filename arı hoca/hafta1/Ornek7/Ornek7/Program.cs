using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2 - Kullanıcının girdiği değerler ile üçgenin alanını ve çevresini hesaplayan programı yazınız.

            int a, b, c, h, cevre;
            double alan;

            Console.Write("a kenarını gir");
            a = int.Parse(Console.ReadLine());


            Console.Write("b kenarını gir");
            b = int.Parse(Console.ReadLine());


            Console.Write("c kenarını gir");
            c = int.Parse(Console.ReadLine());


            Console.Write("h kenarını gir");
            h = int.Parse(Console.ReadLine());

            cevre = a + b + c;
            alan = a * h / 2;

            Console.WriteLine("Üçgenin alanı = "+alan);
            Console.WriteLine("Üçgenin Çevresi = "+cevre);

            Console.ReadLine();
        }
    }
}
