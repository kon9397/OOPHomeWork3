using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            YellowPrinter printer = new YellowPrinter();
            printer.Print("Hello world...");

            Printer printer1 = printer;
            printer1.Print("Hello world");

            RedPrinter printer2 = new RedPrinter();
            printer2.Print("Hello world");

            printer1 = printer2;
            printer1.Print("Hello world");

            Console.ReadKey();
        }
    }
}
