using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
	public class TvChannel : IObserver
	{
		public void Update(String breakingNews)
		{
			Console.WriteLine("Breaking News on Tv Channel: " + breakingNews);
		}

	}
}
