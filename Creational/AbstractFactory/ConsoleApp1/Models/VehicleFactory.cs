using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
	public abstract class VehicleFactory
	{
		public abstract IVehicle MakeVehicle(string typeOfVehicle);
		public abstract IEngine AddEngine();

	}
}
