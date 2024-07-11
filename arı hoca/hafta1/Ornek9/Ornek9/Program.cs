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

            //4 - Kullanıcının girdiği değerler ile dikdörtgenin alanını ve çevresini hesaplayan programı yazınız.

            int a, b,cevre;
            double alan;

            Console.WriteLine("a kenarını gir");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("b kenarını gir");
            b = int.Parse(Console.ReadLine());

            cevre = 2 * (a + b);
            alan = a * b;

            Console.WriteLine("Çevre =" + cevre);
            Console.WriteLine("Alan =" + alan);

            Console.ReadLine();
        }
    }
}
