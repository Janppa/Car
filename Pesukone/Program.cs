using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pesukone
{
    class Program
    {
        static void Main(string[] args)
        {
            Pesukone pesukone = new Pesukone();
            pesukone.IsOn = true;
            pesukone.Temperature = 60;
            pesukone.Color = "White";
            pesukone.Brand = "LG";
            pesukone.Speed = 120;
            pesukone.PrintData();
            pesukone.ShutDown();





        }
    }
}
