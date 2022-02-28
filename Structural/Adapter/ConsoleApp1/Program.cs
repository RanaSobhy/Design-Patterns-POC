using ConsoleApp1.Models;
using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            IMonitor ledTV = new LedTV();

            Printer printer = new Printer();
            IMonitor adapter = new MonitorPrinterAdapter(printer);

            String message = "Hello";
            ledTV.Display(message);
            adapter.Display(message);

            Console.ReadLine();
        }
    }
}
