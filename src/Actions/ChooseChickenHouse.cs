using System;
using System.Collections.Generic;
using System.Linq;
using Trestlebridge;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
    public class ChooseChickenHouse
    {
        public static void CollectInput(Farm farm, IChicken animal)
        {
            Utils.Clear();
            List<ChickenHouse> maxChickenList = farm.ChickenHouses.Where(house => house.Capacity < house.MaxCapacity).ToList();

            for (int i = 0; i < maxChickenList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Chicken House {maxChickenList[i].Capacity}");
            }

            Console.WriteLine();

            // How can I output the type of animal chosen here?
            Console.WriteLine($"Place the animal where?");
            Console.WriteLine();

            Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine());
            choice--;
            ChosenFacility(choice, animal, maxChickenList);
        }
        public static void ChosenFacility(int option, IChicken animal, List<ChickenHouse> availableChickenHouseList)
        {

            availableChickenHouseList[option].AddResource(animal);
        }

        /*
            Couldn't get this to work. Can you?
            Stretch goal. Only if the app is fully functional.
         */
        // farm.PurchaseResource<IGrazing>(animal, choice);

    }
}