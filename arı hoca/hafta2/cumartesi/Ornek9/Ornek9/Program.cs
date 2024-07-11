using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // boyutunu ve elemanlarını kullanıcının belirlediği string bir dizi oluşturunuz. Dizinin içerisinde bulunan elamanların alfabetik sıra numaralarının toplamını ekrana yazan fonksiyonu yazınız.

            // boyutunu ve elemanlarını kullacının belirlediği 2 boyutlu int bir dizi tanımlayınız. elemanlarının rastgele değerler olarak otomatik verilmesini sağlayınız. elemanların toplamını ekrana yazdırınız.

            int[,] ikiboyut = new int[5, 4];

            Random rnd=new Random();
            for (int i = 0; i < 80; i++)
            {
                Console.WriteLine(rnd.Next(1, 96));
            }            

            Console.ReadLine();

        }
    }
}
