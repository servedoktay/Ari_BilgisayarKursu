using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullacının girdiği üs ve taban bilgisine göre girilen sayının üssünü hesaplayınız.

            int taban, us, sonuc;
            sonuc = 1;

            Console.WriteLine("taban değerini gir");
            taban = int.Parse(Console.ReadLine());

            Console.WriteLine("üs değerini gir");
            us = int.Parse(Console.ReadLine());

            for (int i = 0; i < us; i++)
            {
                sonuc *= taban;                 
            }

            Math.Pow(taban, us); // ikinci yöntem

            Console.WriteLine(sonuc);
            Console.ReadLine();
        }
    }
}
