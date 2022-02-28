using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
	public abstract class HouseDecorator : House
	{
		protected House decoratedHouse;

		public HouseDecorator(House house)
		{
			this.decoratedHouse = house;
		}

		public override void BuildHouse()
		{
			decoratedHouse.BuildHouse();
		}

	}
}
