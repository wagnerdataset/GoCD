using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoCD
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 0; x < 50; x++)
            {
                Console.WriteLine("Valor de x: " + x.ToString());
            }

            Console.ReadKey();
        }
    }
}
