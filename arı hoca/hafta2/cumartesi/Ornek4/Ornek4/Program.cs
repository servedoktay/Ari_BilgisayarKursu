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
          topla(8, 9);
            topla(8, 91);
            topla(18, 9);
            topla(38, 49);
            topla(8, 94);
            topla(38, 93);
            topla(38, 29);
            Console.ReadLine();
                           

        }

        static void topla(int sayi1,int sayi2)
        {             

            Console.WriteLine(sayi1 + sayi2);
                     
        }
    }
}
