using System;
using System.Collections.Generic;
using System.Text;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Facilities
{
    public class NaturalField : IFacility<INatural>
    {
        private int _capacity = 50;
        private Guid _id = Guid.NewGuid();

        private List<INatural> _animals = new List<INatural>();

        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }

        public void AddResource(INatural animal)
        {
            // TODO: implement this...
            throw new NotImplementedException();
        }

        public void AddResource(List<INatural> animals)
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

            output.Append($"Natural field {shortId} has {this._animals.Count} animals\n");
            this._animals.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}