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
            // Kullacının girdiği 10 sayıdan tekleri ayrı çiftleri ayrı toplayan ve toplamları ekrana yazan programı yazınız.

            int sayi, tektoplam, cifttoplam;
            cifttoplam = 0;
            tektoplam = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Sayi gir");
                sayi = int.Parse(Console.ReadLine());
                if (sayi % 2 == 0)
                {
                    cifttoplam = cifttoplam + sayi;
                }
                else
                {
                    tektoplam = tektoplam + sayi;
                }
            }
            Console.WriteLine(cifttoplam);
            Console.WriteLine(tektoplam);
            Console.ReadLine();

        }
    }
}
