﻿using System;
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

            string teste = ConfigurationManager.AppSettings["dnauth"];
            Console.WriteLine(teste);

            Console.ReadKey();
        }
    }
}
