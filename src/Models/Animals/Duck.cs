using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals
{
    public class Duck : IResource, IDuckHouse
    {

        private Guid _id = Guid.NewGuid();

        private string _shortId
        {
            get
            {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }

        public double WetFeet { get; set; }
        public int EggQuantity { get; set; } = 6;
        public string Type { get; } = "Duck";

        // Methods
        public void Graze()
        {
            Console.WriteLine($"Duck {this._shortId} has {this.WetFeet}on him");
        }

        public override string ToString()
        {
            return $"Duck {this._shortId}. Quack!";
        }
    }
}