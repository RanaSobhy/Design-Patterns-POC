using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
	public class PayPalStrategy : IPaymentTypeStrategy
	{
		public string Email { get; set; }
		public string Password { get; set; }

		public PayPalStrategy(string email, string password)
		{
			this.Email = email;
			this.Password = password;
		}

		public void Pay(double amount)
		{
			Console.WriteLine(amount + " is payed using PayPal");

		}
	}
}
