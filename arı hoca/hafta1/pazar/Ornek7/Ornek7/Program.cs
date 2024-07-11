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
            // Kullanıcının girdiği 2 sayı arasındaki çift sayıları  ekrana yazan programı yazınız.

            int s1, s2;

            Console.WriteLine("sayı gir");
            s1 = int.Parse(Console.ReadLine());

            Console.WriteLine("sayı gir");
            s2 = int.Parse(Console.ReadLine());

            if (s1 < s2)
            {
                for (int i = s1; i < s2; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else if (s2 < s1)
            {
                for (int i = s2; i < s1; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                Console.WriteLine("sayılar eşit");
            }

            Console.ReadLine();

        }
    }
}
