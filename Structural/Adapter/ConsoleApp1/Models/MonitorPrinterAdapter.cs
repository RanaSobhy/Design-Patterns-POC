using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
	public class MonitorPrinterAdapter : IMonitor
	{
        readonly Printer printer;
		public MonitorPrinterAdapter(Printer printer)
		{
			this.printer = printer;
		}

		public void Display(string message)
		{
			printer.Print(message);
		}

	}
}
