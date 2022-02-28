using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
	public class CombatPlane : IVehicle
	{
		public void Move()
		{
			Console.WriteLine("Combat Plane is flying");
		}

	}
}
