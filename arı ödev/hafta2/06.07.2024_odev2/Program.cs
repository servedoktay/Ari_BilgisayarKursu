using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._07._2024_odev2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dizinin satır sayısını giriniz:");
            int satir = int.Parse(Console.ReadLine());

            Console.WriteLine("Dizinin sütun sayısını giriniz:");
            int sutun = int.Parse(Console.ReadLine());

            int[,] dizi = new int[satir, sutun];
            Random rastgele = new Random();
            int toplam = 0;

            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    dizi[i, j] = rastgele.Next(0, 101); 
                    toplam += dizi[i, j];
                }
            }

            Console.WriteLine("\nDizinin elemanları:");
            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    Console.Write($"{dizi[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"\nElemanların toplamı: {toplam}");

            Console.ReadKey();
        }
    }
}
