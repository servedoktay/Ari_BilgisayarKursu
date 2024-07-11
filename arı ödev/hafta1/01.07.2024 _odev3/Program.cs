using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._07._2024__odev3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vize1, vize2, final;
            double ort, v1a, v2a, fa;
            v1a = 0.2;
            v2a = 0.2;
            fa = 0.6;
            Console.WriteLine("1.vize notunuzu giriniz");
            vize1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2.vize notunuzu giriniz");
            vize2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Final notunuzu giriniz");
            final = Convert.ToInt32(Console.ReadLine());
            

            if ((vize1 >=0 && vize1<=100)&& (vize2 >= 0 && vize2 <= 100) && (final >= 0 && final <= 100))
            {
                ort = (vize1 * v1a) + (vize2 * v2a) + (final * fa);
                if (ort >=55)
                {
                    Console.WriteLine("Gectiniz!!!  {0}",ort);
                }
                else if (ort <55)
                    Console.WriteLine("Kaldınız!!!  {0}",ort);
            }
            else Console.WriteLine("Girilen notlar 100 den buyuk olamaz");
            Console.ReadKey();


        }
    }
}
