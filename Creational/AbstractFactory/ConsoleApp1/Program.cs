using ConsoleApp1.Models;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
			VehicleFactory planeFactory = new PlaneFactory();
			IVehicle plane = planeFactory.MakeVehicle("Passenger Plane");
			IEngine planeEngine = planeFactory.AddEngine();
			if (plane != null)
			{
				planeEngine.StartEngine();
				plane.Move();
			}

			VehicleFactory carFactory = new CarFactory();
			IVehicle car = carFactory.MakeVehicle("Family Car");
			IEngine carEngine = carFactory.AddEngine();
			if (car != null)
			{
				carEngine.StartEngine();
				car.Move();
			}

			Console.ReadLine();
		}
    }
}
