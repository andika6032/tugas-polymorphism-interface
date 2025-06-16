using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasPolymorphism
{
    class LaserJet : IPrinterWindows
    {
        public void Show()
        {
            Console.WriteLine("Printer LaserJet display dimension: 12 *12");
        }
        public void Print()
        {
            Console.WriteLine("Printer LaserJet printing....");
        }
    }
}
