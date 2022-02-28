using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
	public class FamilyCar : IVehicle
	{
		public void Move()
		{
			Console.WriteLine("Family Car is driving");
		}
	}
}
