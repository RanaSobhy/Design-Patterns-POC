using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
	public class GardenHouseDecorator : HouseDecorator
	{

		public GardenHouseDecorator(House house): base(house)
		{
		}

		public override void BuildHouse()
		{
			base.BuildHouse();
			AddGarden();
		}

		private void AddGarden()
		{
			Console.WriteLine("Garden is added");
		}

	}
}
