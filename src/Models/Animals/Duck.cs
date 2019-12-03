using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals
{
    public class Duck : IResource, IDuck
    {

        private Guid _id = Guid.NewGuid();

        private string _shortId
        {
            get
            {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }

        public double FeedPerDay { get; set; } = 0.9;
        public string Type { get; } = "Duck";
        public int FeedLevel { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        // Methods
        public void Graze()
        {
            Console.WriteLine($"Duck {this._shortId} just ate {this.FeedPerDay}kg of feed");
        }



        public override string ToString()
        {
            return $"Duck {this._shortId}. Quack!";
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