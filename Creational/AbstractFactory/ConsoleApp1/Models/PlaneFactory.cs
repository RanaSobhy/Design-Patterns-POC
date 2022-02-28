using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
	public class PlaneFactory : VehicleFactory
	{
		public override IVehicle MakeVehicle(string typeOfVehicle)
		{
			if (typeOfVehicle == "Combat Plane")
			{
				return new CombatPlane();
			}
			else if (typeOfVehicle == "Passenger Plane")
			{
				return new PassengerPlane();
			}

			return null;
		}

		public override IEngine AddEngine()
		{
			return new PlaneEngine();
		}

	}
}
