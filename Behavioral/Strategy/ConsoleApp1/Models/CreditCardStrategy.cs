using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
	public class CreditCardStrategy : IPaymentTypeStrategy
	{
		public string Name { get; set; }
		public string CardNumber { get; set; }
		public string Cvv { get; set; }
		public string DateOfExpiry { get; set; }

		public CreditCardStrategy(string name, string cardNumber, string cvv, string dateOfExpiry)
		{
			this.Name = name;
			this.CardNumber = cardNumber;
			this.Cvv = cvv;
			this.DateOfExpiry = dateOfExpiry;
		}

		public void Pay(double amount)
		{
			Console.WriteLine(amount + " is a payed with CreditCard");

		}
	}
}
