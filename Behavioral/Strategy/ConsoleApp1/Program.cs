using ConsoleApp1.Models;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
			ShoppingCart shoppingCart1 = new ShoppingCart();

			Item apple = new Item("Apple", 1);
			Item orange = new Item("Orange", 2);

			shoppingCart1.AddToCart(apple);
			shoppingCart1.AddToCart(orange);

			ShoppingCart shoppingCart2 = new ShoppingCart();
			shoppingCart2.AddToCart(apple);
			shoppingCart2.AddToCart(orange);
			shoppingCart2.RemoveFromCart(apple);

			shoppingCart1.Pay(new CreditCardStrategy("test", "21312", "322", "01/24"));
			shoppingCart2.Pay(new PayPalStrategy("test@mail.com", "1234"));

			Console.ReadLine();
		}
    }
}
