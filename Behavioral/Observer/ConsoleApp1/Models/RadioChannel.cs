using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
	public class RadioChannel : IObserver
	{
		public void Update(String breakingNews)
		{
			Console.WriteLine("Breaking News on Radio Channel: " + breakingNews);
		}

	}
}
