using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
	public interface IObserver
	{
		public void Update(String breakingNews);
	}
}
