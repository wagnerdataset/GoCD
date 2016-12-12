using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoCD.Layers {
    public class ProcessData : IProcessData {
        public bool Execute() {
            try {
                for (var x = 0; x < 50; x++) {
                    Console.WriteLine("Valor de x: " + x.ToString());
                }

                return true;
            } catch (Exception ex) {
                Console.WriteLine($"{ex}");
                return false;
            }
        }
    }
}
