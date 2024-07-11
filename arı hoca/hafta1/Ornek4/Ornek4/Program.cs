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
            int s1, s2,sonuc;

            Console.WriteLine("sayı girin");
            s1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("sayı girin");
            s2 = Convert.ToInt32(Console.ReadLine());

            sonuc = s1 + s2;

            Console.WriteLine(sonuc);                

            Console.ReadLine();

        }
    }
}
