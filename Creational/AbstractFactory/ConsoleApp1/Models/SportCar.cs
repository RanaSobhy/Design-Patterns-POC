using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
	public class SportCar : IVehicle
	{
		public void Move()
		{
			Console.WriteLine("Sport Car is driving");
		}
	}
}
