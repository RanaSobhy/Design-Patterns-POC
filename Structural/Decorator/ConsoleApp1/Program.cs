using ConsoleApp1.Models;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            House houseWithBalconyAndGarden = new GardenHouseDecorator(new BalconyHouseDecorator(new BasicHouse()));

            houseWithBalconyAndGarden.BuildHouse();

            Console.ReadLine();
        }
    }
}
