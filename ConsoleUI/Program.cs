using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ISP stands for "Interface Segregation Principle" - pattern design
// ISP states that a client should not be forced to depend on an interfaces they don't use
namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IBorrowableDVD dvd = new DVD();


            Console.ReadLine();
        }
    }
}
