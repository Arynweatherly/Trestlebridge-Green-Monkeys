using System;
using System.Collections.Generic;
using System.Linq;
using Trestlebridge;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
    public class ChooseChickenHouse
    {
        public static void CollectInput(Farm farm, IChicken animal)
        {
            Utils.Clear();

            for (int i = 0; i < farm.ChickenHouses.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Chicken House {farm.ChickenHouses[i].Capacity}");
            }

            Console.WriteLine();

            // How can I output the type of animal chosen here?
            Console.WriteLine($"Place the animal where?");
            Console.WriteLine();

            Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine());
            choice--;
            if (farm.ChickenHouses[choice].Capacity < farm.ChickenHouses[choice].MaxCapacity)
            {
                farm.ChickenHouses[choice].AddResource(animal);
                Console.WriteLine("Hit enter to return to main menu.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Too many chickens in this house. Pick a different house.");
                Console.ReadLine();

            }

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);

        }
    }
}