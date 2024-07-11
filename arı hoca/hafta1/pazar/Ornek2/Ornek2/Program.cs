using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcının girdiği kelimenin harf sayısını bulan programı yazınız.

            string kelime;

            Console.WriteLine("kelime gir");
            kelime = Console.ReadLine();

            Console.WriteLine(kelime.Length.ToString());

            Console.ReadLine();

        }
    }
}
