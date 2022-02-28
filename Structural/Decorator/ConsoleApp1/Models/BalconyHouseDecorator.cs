using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
	public class BalconyHouseDecorator : HouseDecorator
	{
		public BalconyHouseDecorator(House house): base(house)
		{
		}

		public override void BuildHouse()
		{
			base.BuildHouse();
			AddBalcony();

		}

		private void AddBalcony()
		{
			Console.WriteLine("Balcony is added");
		}

	}
}
