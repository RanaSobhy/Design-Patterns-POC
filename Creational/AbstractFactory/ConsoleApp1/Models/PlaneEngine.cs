using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
	public class PlaneEngine : IEngine
	{
		public void StartEngine()
		{
			Console.WriteLine("Plane engine started.");
		}

	}
}
