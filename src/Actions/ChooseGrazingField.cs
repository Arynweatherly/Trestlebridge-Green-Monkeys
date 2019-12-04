using System;
using System.Collections.Generic;
using System.Linq;
using Trestlebridge;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
    public class ChooseGrazingField
    {
        public static void CollectInput(Farm farm, IGrazing animal)
        {
            Utils.Clear();

            for (int i = 0; i < farm.GrazingFields.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Grazing Field {farm.GrazingFields[i].Capacity}");
            }

            Console.WriteLine();

            // How can I output the type of animal chosen here?
            Console.WriteLine($"Place the animal where?");
            Console.WriteLine();

            Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine());
            choice--;
            if (farm.GrazingFields[choice].Capacity < farm.GrazingFields[choice].MaxCapacity)
            {
                farm.GrazingFields[choice].AddResource(animal);
            }
            else
            {
                Console.WriteLine("Too many animals in this field. Pick a different field.");
                int secondChoice = Int32.Parse(Console.ReadLine());
                secondChoice--;
                farm.GrazingFields[secondChoice].AddResource(animal);
            }

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);

        }
    }
}