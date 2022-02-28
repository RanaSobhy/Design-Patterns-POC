using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
	public class CarFactory : VehicleFactory
	{
		public override IVehicle MakeVehicle(string typeOfVehicle)
		{
			if (typeOfVehicle == "Sport Car")
			{
				return new SportCar();
			}
			else if (typeOfVehicle == "Family Car")
			{
				return new FamilyCar();
			}

			return null;
		}
		public override IEngine AddEngine()
		{
			return new CarEngine();
		}
    }
}
