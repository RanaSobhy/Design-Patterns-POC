using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
	public class PassengerPlane : IVehicle
	{
		public void Move()
		{
			Console.WriteLine("Passenger plane is flying");
		}

	}
}
