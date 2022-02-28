using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
	public interface IPaymentTypeStrategy
	{
		public void Pay(double amount);
	}
}
