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
    public class ChooseGrazingField
    {
        public static void CollectInput(Farm farm, IGrazing animal)
        {
            Utils.Clear();
            List<GrazingField> maxGrazingList = farm.GrazingFields.Where(field => field.Capacity < field.MaxCapacity).ToList();

            for (int i = 0; i < maxGrazingList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Grazing Field {maxGrazingList[i].Capacity}");
            }

            Console.WriteLine();

            // How can I output the type of animal chosen here?
            Console.WriteLine($"Place the animal where?");
            Console.WriteLine();

            Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine());
            choice--;
            ChosenFacility(choice, animal, maxGrazingList);
        }
        public static void ChosenFacility(int option, IGrazing animal, List<GrazingField> availableGrazingFieldList)
        {
            availableGrazingFieldList[option].AddResource(animal);
        }

        /*
            Couldn't get this to work. Can you?
            Stretch goal. Only if the app is fully functional.
         */
        // farm.PurchaseResource<IGrazing>(animal, choice);

    }
}