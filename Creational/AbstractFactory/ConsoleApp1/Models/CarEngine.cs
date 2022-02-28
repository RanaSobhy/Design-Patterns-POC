using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
	public class CarEngine : IEngine
	{
		public void StartEngine()
		{
			Console.WriteLine("Car Engine started");
		}
	}
}
