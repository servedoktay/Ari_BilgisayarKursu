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
            // Döngü kullanarak aşağıdaki şekli oluşturunuz

            /*
              
             *
             **
             ***
             ****
             *****
             ******
             *******
             ********
             *********
             **********           
             
            */

            for (int i = 0; i <= 10; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
