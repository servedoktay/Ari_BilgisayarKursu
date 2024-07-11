using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcının girdiği 2 sayı arasındaki sayıları ekrana yazan programı yazınız.

           

            int s1, s2;
            Console.WriteLine("sayı gir");
            s1 = int.Parse(Console.ReadLine());

            Console.WriteLine("sayı gir");
            s2 = int.Parse(Console.ReadLine());

            if (s1>s2)
            {
                for (int i = s2+1; i < s1; i++)
                {
                    Console.WriteLine(i.ToString());
                }
            }
            else if(s2>s1) 
            {
                for (int i = s1 + 1; i < s2; i++)
                {
                    Console.WriteLine(i.ToString());
                }
            }
            else
            {
                Console.WriteLine("Sayılar eşittir");
            }
            Console.ReadLine();

        }
    }
}
