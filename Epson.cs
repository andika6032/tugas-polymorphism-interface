using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasPolymorphism
{
    class Epson : IPrinterWindows
    {
        public void Show()
        {
            Console.WriteLine("Printer Epson display dimension: 10*11");
        }
        public void Print()
        {
            Console.WriteLine("Printer Epson printing....");
        }
    }
  
 }
