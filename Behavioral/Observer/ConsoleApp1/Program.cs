using ConsoleApp1.Models;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
			NewsAgency myNewsAgency = new NewsAgency();
			myNewsAgency.UpdateNews("This is the news number 1");

			TvChannel myTvChannel = new TvChannel();
			myNewsAgency.Register(myTvChannel);

			myNewsAgency.UpdateNews("This is the news number 2");

			RadioChannel myRadioChannel = new RadioChannel();
			myNewsAgency.Register(myRadioChannel);

			myNewsAgency.UpdateNews("This is the news number 3");

			myNewsAgency.Unregister(myTvChannel);

			myNewsAgency.UpdateNews("This is the news number 4");

			Console.ReadLine();
		}
    }
}
