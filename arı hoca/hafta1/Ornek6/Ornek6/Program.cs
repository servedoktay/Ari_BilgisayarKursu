using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Ornek6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 - Kullanıcının girdiği 5 sayının toplamını ve ortalamasını ekrana yazan programı yazınız.

            int s1, s2, s3, s4, s5,toplam;
            double ortalama;

            Console.WriteLine("Sayı gir");
            s1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Sayı gir");
            s2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Sayı gir");
            s3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Sayı gir");
            s4 = int.Parse(Console.ReadLine());

            Console.WriteLine("Sayı gir");
            s5 = int.Parse(Console.ReadLine());

            toplam = s1 + s2 + s3 + s4 + s5;

            ortalama = toplam / 5;

            Console.WriteLine(toplam);
            Console.WriteLine(ortalama);

            Console.ReadLine();
        }
    }
}
