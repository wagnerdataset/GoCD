using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoCD
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = ConfigurationManager.AppSettings["Title"];

            for (int x = 0; x < 50; x++)
            {
                Console.WriteLine("Valor de x: " + x.ToString());
            }

            Console.ReadKey();
        }
    }
}
