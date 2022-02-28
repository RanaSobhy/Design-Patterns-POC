using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
	public class BasicHouse : House
	{
		public override void BuildHouse()
		{
			Console.WriteLine("Basic house is built");
		}

	}
}
