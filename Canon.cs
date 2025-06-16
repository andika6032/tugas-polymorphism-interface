using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasPolymorphism
{
    class Canon : IPrinterWindows
    {
        public void Show()
        {
            Console.WriteLine("Printer Canon display dimension: 9.5*12");
        }
        public void Print()
        {
            Console.WriteLine("Printer Canon printing....");
        }
    }
}
