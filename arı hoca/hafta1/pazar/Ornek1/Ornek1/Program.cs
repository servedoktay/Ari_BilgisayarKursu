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
            // Kullanıcının girdiği 3 sayıdan en büyük ve en küçük olan sayıların ortalamasını bulan programı yazınız.

            

            int s1, s2, s3, enb, enk;
            double ort;
            enk = 0;
            enb = 0;

            Console.WriteLine("Sayı gir");
            s1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Sayı gir");
            s2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Sayı gir");
            s3 = int.Parse(Console.ReadLine());

            if (s1>s2 && s1>s3)
            {
                enb = s1;
            }

            if (s2 > s1 && s2 > s3)
            {
                enb = s2;
            }

            if (s3 > s1 && s3 > s2)
            {
                enb = s3;
            }

            if (s1 < s2 && s1 < s3)
            {
                enk = s1;
            }

            if (s2 < s1 && s2 < s3)
            {
                enk = s2;
            }

            if (s3 < s1 && s3 < s2)
            {
                enk = s3;
            }

            if (s3 == s1 && s3 == s2)
            {
                Console.WriteLine("Tüm Sayılar eşit");
            }

            ort = (enb + enk) / 2;

            Console.WriteLine("Ortalama =>" + ort);
            Console.ReadLine();
        }
    }
}
