using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
    public class CreateFacility
    {
        public static void CollectInput(Farm farm)
        {
            Console.WriteLine("1. Grazing field");
            Console.WriteLine("2. Chicken House");


            Console.WriteLine();
            Console.WriteLine("Choose what you want to create");

            Console.Write("> ");
            string input = Console.ReadLine();

            switch (Int32.Parse(input))
            {
                case 1:
                    farm.AddGrazingField(new GrazingField());
                    Console.WriteLine("You have created a grazing field!");
                    Console.WriteLine("Hit Enter again to return to the main menu");
                    Console.ReadLine();
                    break;
                case 2:
                    farm.AddChickenHouse(new ChickenHouse());
                    Console.WriteLine("You have created a chicken house!");
                    Console.WriteLine("Hit Enter again to return to the main menu");
                    Console.ReadLine();
                    break;

                default:
                    break;
            }
        }
    }
}