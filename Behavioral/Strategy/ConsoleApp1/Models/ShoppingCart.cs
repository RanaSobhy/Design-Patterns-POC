using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
	public class ShoppingCart
	{
        readonly List<Item> Items;

		public ShoppingCart()
		{
			this.Items = new List<Item>();
		}

		public void AddToCart(Item item)
		{
			this.Items.Add(item);
		}

		public void RemoveFromCart(Item item)
		{
			this.Items.Remove(item);
		}

		public double CalculateTotal()
		{
			double total = 0;
			foreach (var item in Items)
			{
				total += item.Price;
			}
			return total;
		}

		public void Pay(IPaymentTypeStrategy paymentTypeStrategy)
		{
			double amount = CalculateTotal();
			paymentTypeStrategy.Pay(amount);
		}

	}
}
