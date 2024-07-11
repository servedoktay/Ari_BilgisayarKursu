using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5 - Kullacının girdiği vize ve final notları ile öğrencinin ortalamasını hesaplayınız. vize %40 final %60 olarak ortalamaya katkı sağlamaktadır.


            int vize, final;
            double ortalama;

            Console.WriteLine("vize gir");
            vize = int.Parse(Console.ReadLine());

            Console.WriteLine("final gir");
            final = int.Parse(Console.ReadLine());

            ortalama = (vize * 0.4) + (final * 0.6);

            Console.WriteLine(ortalama);
            Console.ReadLine();
        }
    }
}
