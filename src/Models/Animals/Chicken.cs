using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals
{
    public class Chicken : IResource, IMeatProducing, IChicken
    {

        private Guid _id = Guid.NewGuid();
        private double _meatProduced = 1.7;

        private string _shortId
        {
            get
            {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }

        public double FeedPerDay { get; set; } = 0.9;
        public string Type { get; } = "Chicken";
        public int FeedLevel { get =>
                throw new NotImplementedException(); set =>
                throw new NotImplementedException(); }

        // Methods
        public void Graze()
        {
            Console.WriteLine($"Chicken {this._shortId} just ate {this.FeedPerDay}kg of feed");
        }

        public double Butcher()
        {
            return _meatProduced;
        }

        public override string ToString()
        {
            return $"Chicken {this._shortId}. Cluck!";
        }

        public void Feed()
        {
            throw new NotImplementedException();
        }

        public void EggGather()
        {
            throw new NotImplementedException();
        }

        public void FeatherHarvester()
        {
            throw new NotImplementedException();
        }
    }
}