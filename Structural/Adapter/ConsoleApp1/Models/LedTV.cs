using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
	public class LedTV : IMonitor
	{
		public void Display(string message)
		{
			Console.WriteLine("The message " + message + " is displaying on LED TV");
		}

	}
}
