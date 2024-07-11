using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // boyutunu ve elemanlarını kullanıcının belirlediği int bir dizi oluşturunuz, küçükten büyüğe sıralayınız ve ortalamasını hesaplayınız.

            int boyut, eleman;

            Console.WriteLine("dizinin boyutunu gir");
            boyut = int.Parse(Console.ReadLine());

            int[] dizi=new int[boyut];

            for (int i = 0; i < boyut; i++)
            {
                Console.WriteLine("dizi elemanı gir");
                eleman = int.Parse(Console.ReadLine());
                dizi[i] = eleman;
            }
            Array.Sort(dizi);

            for (int i = 0; i < boyut; i++)
            {
                Console.WriteLine(dizi[i]);
            }
            int ort = 0;
            for (int i = 0; i < boyut; i++)
            {
                ort+=dizi[i];                
            }

            ort = ort / boyut;
            Console.WriteLine(ort);
            Console.ReadLine();
        }
    }
}
