using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcının girdiği bir kelimeyi tersten yazan programı yazınız.

            string kelime;
            Console.WriteLine("Kelime gir");
            kelime = Console.ReadLine();           

            for (int i = kelime.Length-1; i > -1; i--)
            {
                Console.Write(kelime[i]);
            }


            Console.ReadLine();

        }
    }
}
