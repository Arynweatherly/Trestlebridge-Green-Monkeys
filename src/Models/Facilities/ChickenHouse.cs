using System;
using System.Collections.Generic;
using System.Text;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Facilities
{
    public class ChickenHouse : IFacility<IChicken>
    {
        private int _capacity = 0;
        private int _maxCapacity = 1;

        private Guid _id = Guid.NewGuid();

        private List<IChicken> _animals = new List<IChicken>();

        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }
        public double MaxCapacity
        {
            get
            {
                return _maxCapacity;
            }
        }

        public void AddResource(IChicken animal)
        {
            _animals.Add(animal);
            _capacity++;
            Console.WriteLine("Yayyyy you purchased a chicken!! What what!!??");
            Console.WriteLine("Hit Enter again to return to the main menu");
            Console.ReadLine();
        }

        public void AddResource(List<IChicken> animals)
        {
            // TODO: implement this...
            throw new NotImplementedException();
        }

        internal static void CollectInput(string input)
        {
            throw new NotImplementedException();
        }

        internal static void input(object trestlebridge)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Chicken House {shortId} has {this._animals.Count} animals\n");
            this._animals.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}