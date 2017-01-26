using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pesukone
{
    class Pesukone
    {
        public bool IsOn { get; set; }
        public int Temperature { get; set; }
        public int Speed { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }
        public void ShutDown()
        {
            Console.WriteLine("Pesukone on sammunut ");
        }

        public void PrintData()
        {
            Console.WriteLine("Power on : "+IsOn);
            Console.WriteLine("- Brand : " + Brand);
            Console.WriteLine("- Bolor : " + Color);
            Console.WriteLine("- Temperature : " + Temperature);
            Console.WriteLine("- Speed : " + Speed);
        
      
        }

    }
}
