using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
	public interface ISubject
	{ 

		public void Register(IObserver observer);
		public void Unregister(IObserver observer);
		public void NotifyObservers();

	}
}
