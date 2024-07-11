using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ornek6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullacının girdiği 2 sayı arasındaki asal sayıları bulan fonksiyonu yazınız.

            asalListele(1, 50);


        }

        static void asalListele(int sayi1,int sayi2)
        {
            
            for (int i = sayi1; i < sayi2; i++)
            {
                bool durum = false;
                for (int j = 2; j < i; j++)
                {
                    if (i % j==0)
                    {
                        durum = true;
                    }

                }
                if (durum==true)
                {
                    
                }
                else
                {
                    Console.Write(i + " , ");
                }

            }
            Console.ReadLine();

        }
    }
}
